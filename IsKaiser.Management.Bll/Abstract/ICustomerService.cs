using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsKaiser.Management.Bll.Abstract
{
    public interface ICustomerService
    {
        void AddWithTransaction(Customer customer,CustomerAccountant accountant,CustomerDirector director,
            CustomerPurchasingStaff purchasingStaff);
        void UpdateWithTransaction(Customer customer, CustomerAccountant accountant, CustomerDirector director,
            CustomerPurchasingStaff purchasingStaff);
        void DeleteWithTransaction(Customer customer, CustomerAccountant accountant, CustomerDirector director,
            CustomerPurchasingStaff purchasingStaff);
        Customer Get(int customerId);
        List<Customer> GetAll();
    }
}
