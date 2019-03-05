using IsKaiser.Management.Core.DataAccess.EntityFramework;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System;

namespace IsKaiser.Management.Dal.Concrete.EntityFramework
{
    public class EfVehicleDal : EfRepositoryBase<Vehicle, IsKaiserContext>, IVehicleDal
    {
    }
}
