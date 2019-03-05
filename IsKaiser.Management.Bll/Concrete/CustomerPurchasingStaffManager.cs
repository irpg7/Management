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
    public class CustomerPurchasingStaffManager:ICustomerPurchasingStaffService
    {
        ICustomerPurchasingStaffDal _purchasingStaffDal;

        public CustomerPurchasingStaffManager(ICustomerPurchasingStaffDal purchasingStaffDal)
        {
            _purchasingStaffDal = purchasingStaffDal;
        }
        [FluentValidationAspect(typeof(StaffValidator))]
        public void Add(CustomerPurchasingStaff purchasingStaff)
        {
            _purchasingStaffDal.Add(purchasingStaff);
        }

        public void Delete(CustomerPurchasingStaff purchasingStaff)
        {
            _purchasingStaffDal.Delete(purchasingStaff);
        }

        public CustomerPurchasingStaff Get(int customerId)
        {
            return _purchasingStaffDal.Get(ps => ps.CustomerId == customerId);
        }
        [FluentValidationAspect(typeof(StaffValidator))]
        public void Update(CustomerPurchasingStaff purchasingStaff)
        {
            _purchasingStaffDal.Update(purchasingStaff);
        }
    }
}
