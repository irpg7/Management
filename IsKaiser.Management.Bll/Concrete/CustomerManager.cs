using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Bll.Utilities;
using IsKaiser.Management.Bll.ValidationRules.FluentValidation;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsKaiser.Management.Bll.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add(Customer customer, CustomerAccountant customerAccountant, 
            CustomerDirector customerDirector, CustomerPurchasingStaff purchasingStaff)
        {
            ValidationTool.Validate(new CustomerValidator(), customer);
            ValidationTool.Validate(new AccountantValidator(), customerAccountant);
            ValidationTool.Validate(new DirectorValidator(), customerDirector);
            ValidationTool.Validate(new StaffValidator(), purchasingStaff);
            _customerDal.AddWithTransaction(customer, customerAccountant, customerDirector, purchasingStaff);
        }

        public void Delete(Customer customer, CustomerAccountant customerAccountant,
            CustomerDirector customerDirector, CustomerPurchasingStaff purchasingStaff)
        {
            _customerDal.DeleteWithTransaction(customer, customerAccountant, customerDirector, purchasingStaff);
        }

        public Customer Get(int id)
        {
            return _customerDal.Get(c => c.CustomerId == id);
        }

        public CustomerAccountant GetAccountant(int customerId)
        {
            return _customerDal.GetAccountant(customerId);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public CustomerDirector GetDirector(int customerId)
        {
            return _customerDal.GetDirector(customerId);
        }

        public CustomerPurchasingStaff GetPurchasingStaff(int customerId)
        {
            return _customerDal.GetPurchasingStaff(customerId);
        }

        public void Update(Customer customer, CustomerAccountant customerAccountant, 
            CustomerDirector customerDirector, CustomerPurchasingStaff purchasingStaff)
        {
            ValidationTool.Validate(new CustomerValidator(), customer);
            ValidationTool.Validate(new AccountantValidator(), customerAccountant);
            ValidationTool.Validate(new DirectorValidator(), customerDirector);
            ValidationTool.Validate(new StaffValidator(), purchasingStaff);
            _customerDal.UpdateWithTransaction(customer,customerAccountant,customerDirector,purchasingStaff);
        }
    }
}
