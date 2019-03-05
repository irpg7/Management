using IsKaiser.Management.Core.DataAccess;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Linq;

namespace IsKaiser.Management.Dal.Abstract
{
    public interface ICustomerDal: IEntityRepository<Customer>
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
