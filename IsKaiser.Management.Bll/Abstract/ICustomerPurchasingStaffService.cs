using IsKaiser.Management.Entities.Concrete;
using System;
using System.Linq;

namespace IsKaiser.Management.Bll.Abstract
{
    public interface ICustomerPurchasingStaffService
    {
        void Add(CustomerPurchasingStaff purchasingStaff);
        void Update(CustomerPurchasingStaff purchasingStaff);
        void Delete(CustomerPurchasingStaff purchasingStaff);
        CustomerPurchasingStaff Get(int customerId);
    }
}
