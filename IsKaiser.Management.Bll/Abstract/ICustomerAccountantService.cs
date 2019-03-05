using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IsKaiser.Management.Bll.Abstract
{
    public interface ICustomerAccountantService
    {
        CustomerAccountant Get(int customerId);
    }
}
