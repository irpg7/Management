using IsKaiser.Management.Core.DataAccess;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Linq;

namespace IsKaiser.Management.Dal.Abstract
{
    public interface IEmployeeDal: IEntityRepository<Employee>
    {
    }
}
