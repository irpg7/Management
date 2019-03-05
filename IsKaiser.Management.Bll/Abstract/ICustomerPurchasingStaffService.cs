using IsKaiser.Management.Entities.Concrete;
using System;
using System.Linq;

namespace IsKaiser.Management.Bll.Abstract
{
    public interface ICustomerPurchasingStaffService
    {
        CustomerPurchasingStaff Get(int customerId);
    }
}
