using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.Concrete
{
    public class CustomerPurchasingStaffManager:ICustomerPurchasingStaffService
    {
        ICustomerPurchasingStaffDal _purchasingStaffDal;

        public CustomerPurchasingStaffManager(ICustomerPurchasingStaffDal purchasingStaffDal)
        {
            _purchasingStaffDal = purchasingStaffDal;
        }

        public CustomerPurchasingStaff Get(int customerId)
        {
            return _purchasingStaffDal.Get(ps => ps.CustomerId == customerId);
        }
    }
}
