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
        ICustomerAccountantService _customerAccountantService;
        ICustomerDirectorService _customerDirectorService;
        ICustomerPurchasingStaffService _customerStaffService;

        public CustomerManager(ICustomerDal customerDal, ICustomerAccountantService customerAccountantService,
            ICustomerDirectorService customerDirectorService, ICustomerPurchasingStaffService customerStaffService)
        {
            _customerDal = customerDal;
            _customerAccountantService = customerAccountantService;
            _customerDirectorService = customerDirectorService;
            _customerStaffService = customerStaffService;
        }

        [FluentValidationAspect(typeof(CustomerValidator))]
        public void Add(Customer customer)
        {
            _customerDal.Add(customer);
        }
        [FluentValidationAspect(typeof(CustomerValidator))]
        public void Update(Customer customer)
        {
            _customerDal.Update(customer);
        }

        public void Delete(Customer customer)
        {
            _customerDal.Delete(customer);
        }

        #region TransactionalOperations
        [TransactionScopeAspect]
        public void AddWithTransaction(Customer customer, CustomerAccountant accountant, CustomerDirector director, CustomerPurchasingStaff purchasingStaff)
        {
            Add(customer);
            accountant.CustomerId = customer.CustomerId;
            director.CustomerId = customer.CustomerId;
            purchasingStaff.CustomerId = customer.CustomerId;
            _customerAccountantService.Add(accountant);
            _customerDirectorService.Add(director);
            _customerStaffService.Add(purchasingStaff);
        }
        [TransactionScopeAspect]
        public void DeleteWithTransaction(Customer customer, CustomerAccountant accountant, CustomerDirector director, CustomerPurchasingStaff purchasingStaff)
        {
            Delete(customer);
            _customerDirectorService.Delete(director);
            _customerStaffService.Delete(purchasingStaff);
            _customerAccountantService.Delete(accountant);
        }
        [TransactionScopeAspect]
        public void UpdateWithTransaction(Customer customer, CustomerAccountant accountant, CustomerDirector director, CustomerPurchasingStaff purchasingStaff)
        {
            Update(customer);
            _customerDirectorService.Update(director);
            _customerStaffService.Update(purchasingStaff);
            _customerAccountantService.Update(accountant);
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
