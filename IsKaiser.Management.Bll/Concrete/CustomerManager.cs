using IsKaiser.Management.Bll.Abstract;
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

        public void Add(Customer customer)
        {
            _customerDal.Add(customer);
        }

        public void AddWithTransaction(Customer customer, CustomerAccountant accountant, CustomerDirector director, CustomerPurchasingStaff purchasingStaff)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void DeleteWithTransaction(Customer customer, CustomerAccountant accountant, CustomerDirector director, CustomerPurchasingStaff purchasingStaff)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            return _customerDal.Get(c => c.CustomerId == id);
        }
        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }
        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void UpdateWithTransaction(Customer customer, CustomerAccountant accountant, CustomerDirector director, CustomerPurchasingStaff purchasingStaff)
        {
            throw new NotImplementedException();
        }
    }
}
