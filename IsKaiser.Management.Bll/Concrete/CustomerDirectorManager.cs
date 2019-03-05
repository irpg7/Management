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
    public class CustomerDirectorManager:ICustomerDirectorService
    {
        ICustomerDirectorDal _customerDirectorDal;

        public CustomerDirectorManager(ICustomerDirectorDal customerDirectorDal)
        {
            _customerDirectorDal = customerDirectorDal;
        }
        [FluentValidationAspect(typeof(DirectorValidator))]
        public void Add(CustomerDirector director)
        {
            _customerDirectorDal.Add(director);
        }

        public void Delete(CustomerDirector director)
        {
            _customerDirectorDal.Delete(director);
        }

        public CustomerDirector Get(int customerId)
        {
            return _customerDirectorDal.Get(cd => cd.CustomerId == customerId);
        }
        [FluentValidationAspect(typeof(DirectorValidator))]
        public void Update(CustomerDirector director)
        {
            _customerDirectorDal.Update(director);
        }
    }
}
