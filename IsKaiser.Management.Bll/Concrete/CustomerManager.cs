using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Bll.ValidationRules.FluentValidation;
using IsKaiser.Management.Core.Aspects.Postsharp.ValidationAspects;
using IsKaiser.Management.Core.Aspects.Postsharp.TransactionAspects;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;

using System.Linq;

namespace IsKaiser.Management.Bll.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        [FluentValidationAspect(typeof(CustomerValidator))]
        public void Add(Customer customer)
        {
            _customerDal.Add(customer);
        }
        [FluentValidationAspect(typeof(CustomerValidator))]
        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        #region TransactionalOperations
        [TransactionScopeAspect]
        public void AddWithTransaction(Customer customer, CustomerAccountant accountant, CustomerDirector director, CustomerPurchasingStaff purchasingStaff)
        {
            throw new NotImplementedException();
        }
        public void DeleteWithTransaction(Customer customer, CustomerAccountant accountant, CustomerDirector director, CustomerPurchasingStaff purchasingStaff)
        {
            throw new NotImplementedException();
        }
        public void UpdateWithTransaction(Customer customer, CustomerAccountant accountant, CustomerDirector director, CustomerPurchasingStaff purchasingStaff)
        {
            throw new NotImplementedException();
        }
        #endregion




        public Customer Get(int id)
        {
            return _customerDal.Get(c => c.CustomerId == id);
        }
        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }




    }
}
