using IsKaiser.Management.Bll.Abstract;
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

        public CustomerAccountant Get(int customerId)
        {
           return _customerAccountantDal.Get(ca => ca.CustomerId == customerId);
        }
    }
}
