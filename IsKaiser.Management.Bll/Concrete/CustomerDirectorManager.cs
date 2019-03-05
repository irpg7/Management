using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.Concrete
{
    public class CustomerDirectorManager:ICustomerDirectorService
    {
        ICustomerDirectorDal _customerDirectorDal;

        public CustomerDirectorManager(ICustomerDirectorDal customerDirectorDal)
        {
            _customerDirectorDal = customerDirectorDal;
        }

        public CustomerDirector Get(int customerId)
        {
            return _customerDirectorDal.Get(cd => cd.CustomerId == customerId);
        }
    }
}
