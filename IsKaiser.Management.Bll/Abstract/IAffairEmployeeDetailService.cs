using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.Abstract
{
    public interface IAffairEmployeeDetailService
    {
        void Add(AffairEmployeeDetail affairEmployeeDetail);
        void Update(AffairEmployeeDetail affairEmployeeDetail);
        void Delete(AffairEmployeeDetail affairEmployeeDetail);

        List<AffairEmployeeDetail> GetAllById(int affairId);
        AffairEmployeeDetail Get(int employeeDetailId);
    }
}
