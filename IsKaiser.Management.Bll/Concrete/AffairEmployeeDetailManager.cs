using IsKaiser.Management.Bll.Abstract;
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

        public void Update(AffairEmployeeDetail affairEmployeeDetail)
        {
            _employeeDetailDal.Update(affairEmployeeDetail);
        }
    }
}
