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
    public class CustomerAccountantManager : ICustomerAccountantService
    {
        ICustomerAccountantDal _customerAccountantDal;

        public CustomerAccountantManager(ICustomerAccountantDal customerAccountantDal)
        {
            _customerAccountantDal = customerAccountantDal;
        }
        [FluentValidationAspect(typeof(AccountantValidator))]
        public void Add(CustomerAccountant accountant)
        {
            _customerAccountantDal.Add(accountant);
        }

        public void Delete(CustomerAccountant accountant)
        {
            _customerAccountantDal.Delete(accountant);
        }

        public CustomerAccountant Get(int customerId)
        {
           return _customerAccountantDal.Get(ca => ca.CustomerId == customerId);
        }
        [FluentValidationAspect(typeof(AccountantValidator))]
        public void Update(CustomerAccountant accountant)
        {
            _customerAccountantDal.Update(accountant);
        }
    }
}
