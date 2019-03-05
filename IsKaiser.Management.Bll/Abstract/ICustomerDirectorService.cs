using IsKaiser.Management.Entities.Concrete;
using System;
using System.Linq;

namespace IsKaiser.Management.Bll.Abstract
{
    public interface ICustomerDirectorService
    {
        CustomerDirector Get(int customerId);
    }
}
