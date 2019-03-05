using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Bll.ValidationRules.FluentValidation;
using IsKaiser.Management.Core.Aspects.Postsharp.ValidationAspects;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.Concrete
{
    public class AffairEmployeeDetailManager:IAffairEmployeeDetailService
    {
        IAffairEmployeeDetailDal _employeeDetailDal;

        public AffairEmployeeDetailManager(IAffairEmployeeDetailDal employeeDetailDal)
        {
            _employeeDetailDal = employeeDetailDal;
        }
        [FluentValidationAspect(typeof(AffairEmployeeDetailValidator))]
        public void Add(AffairEmployeeDetail affairEmployeeDetail)
        {
            _employeeDetailDal.Add(affairEmployeeDetail);
        }

        public void Delete(AffairEmployeeDetail affairEmployeeDetail)
        {
            _employeeDetailDal.Delete(affairEmployeeDetail);
        }

        public AffairEmployeeDetail Get(int employeeDetailId)
        {
            return _employeeDetailDal.Get(ed => ed.EmployeeDetailId == employeeDetailId);
        }

        public List<AffairEmployeeDetail> GetAllById(int affairId)
        {
            return _employeeDetailDal.GetAll(ed => ed.AffairId == affairId);
        }
        [FluentValidationAspect(typeof(AffairEmployeeDetailValidator))]
        public void Update(AffairEmployeeDetail affairEmployeeDetail)
        {
            _employeeDetailDal.Update(affairEmployeeDetail);
        }
    }
}
