using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.Abstract
{
    public interface IAffairVehicleDetailService
    {
        void Add(AffairVehicleDetail affairVehicleDetail);
        void Update(AffairVehicleDetail affairVehicleDetail);
        void Delete(AffairVehicleDetail affairVehicleDetail);

        List<AffairVehicleDetail> GetAllById(int affairId);
        AffairVehicleDetail Get(int vehicleDetailId);
    }
}
