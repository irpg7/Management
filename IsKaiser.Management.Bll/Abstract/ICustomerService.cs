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
        List<Customer> GetAll();
        Customer Get(int id);
        CustomerAccountant GetAccountant(int customerId);
        CustomerDirector GetDirector(int customerId);
        CustomerPurchasingStaff GetPurchasingStaff(int customerId);
        void Add(Customer customer, CustomerAccountant customerAccountant
            , CustomerDirector customerDirector, CustomerPurchasingStaff purchasingStaff);
        void Update(Customer customer, CustomerAccountant customerAccountant
            , CustomerDirector customerDirector, CustomerPurchasingStaff purchasingStaff);
        void Delete(Customer customer, CustomerAccountant customerAccountant
            , CustomerDirector customerDirector, CustomerPurchasingStaff purchasingStaff);
     

    }
}
