using PostSharp.Aspects;
using System;
using FluentValidation;
using IsKaiser.Management.Core.CrossCuttingConcerns.Validation.FluentValidation;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace IsKaiser.Management.Core.Aspects.Postsharp.ValidationAspects
{
    [Serializable]
    public class FluentValidationAspect:OnMethodBoundaryAspect
    {
        Type _validatorType;
        public FluentValidationAspect(Type validatorType)
        {
            _validatorType = validatorType;
        }
        public override void OnEntry(MethodExecutionArgs args)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entities = args.Arguments.Where(t => t.GetType() == entityType);
            foreach (var entity in entities)
            {
                ValidationTool.FluentValidate(validator, entity);
            }
        }
    }
}
