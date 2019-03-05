using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IsKaiser.Management.Bll.Abstract
{
    public interface ICustomerAccountantService
    {
        void Add(CustomerAccountant accountant);
        void Update(CustomerAccountant accountant);
        void Delete(CustomerAccountant accountant);
        CustomerAccountant Get(int customerId);
    }
}
