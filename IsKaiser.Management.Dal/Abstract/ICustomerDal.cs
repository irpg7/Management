using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsKaiser.Management.Dal.Abstract
{
    public interface ICustomerDal:IRepository<Customer>
    {
        void AddWithTransaction(Customer customer,CustomerAccountant customerAccountant
            ,CustomerDirector customerDirector,CustomerPurchasingStaff purchasingStaff);
        void UpdateWithTransaction(Customer customer, CustomerAccountant customerAccountant
            , CustomerDirector customerDirector, CustomerPurchasingStaff purchasingStaff);
        void DeleteWithTransaction(Customer customer, CustomerAccountant customerAccountant
            , CustomerDirector customerDirector, CustomerPurchasingStaff purchasingStaff);
        CustomerAccountant GetAccountant(int customerId);
        CustomerDirector GetDirector(int customerId);
        CustomerPurchasingStaff GetPurchasingStaff(int customerId);


    }
}
