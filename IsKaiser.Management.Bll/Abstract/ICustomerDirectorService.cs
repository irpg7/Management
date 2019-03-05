using IsKaiser.Management.Entities.Concrete;
using System;
using System.Linq;

namespace IsKaiser.Management.Bll.Abstract
{
    public interface ICustomerDirectorService
    {
        void Add(CustomerDirector director);
        void Update(CustomerDirector director);
        void Delete(CustomerDirector director);
        CustomerDirector Get(int customerId);
    }
}
