using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Dal.Concrete.EntityFramework
{
    public class EfAffairVehicleDetailDal:EfRepositoryBase<AffairVehicleDetail,IsKaiserContext>,IAffairVehicleDetailDal
    {
    }
}
