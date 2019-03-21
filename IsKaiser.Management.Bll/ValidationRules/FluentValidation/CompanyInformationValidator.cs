using FluentValidation;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.ValidationRules.FluentValidation
{
    public class CompanyInformationValidator:AbstractValidator<CompanyInformation>
    {
        public CompanyInformationValidator()
        {
            RuleFor(ci => ci.Name).NotEmpty().OverridePropertyName("Firma Adı").MaximumLength(100);
            RuleFor(ci => ci.Address).NotEmpty().OverridePropertyName("Firma Adresi").MaximumLength(100);
            RuleFor(ci => ci.TaxDepartment).NotEmpty().OverridePropertyName("Vergi Dairesi").MaximumLength(50);
            RuleFor(ci => ci.TaxNo).NotEmpty().OverridePropertyName("Vergi No.").MaximumLength(25);
        }
    }
}
