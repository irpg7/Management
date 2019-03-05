using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Bll.ValidationRules.FluentValidation;
using IsKaiser.Management.Core.Aspects.Postsharp.ValidationAspects;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.Concrete
{
    public class AffairVehicleDetailManager : IAffairVehicleDetailService
    {
        IAffairVehicleDetailDal _vehicleDetailDal;

        public AffairVehicleDetailManager(IAffairVehicleDetailDal vehicleDetailDal)
        {
            _vehicleDetailDal = vehicleDetailDal;
        }
        [FluentValidationAspect(typeof(AffairVehicleDetailValidator))]
        public void Add(AffairVehicleDetail affairVehicleDetail)
        {
            _vehicleDetailDal.Add(affairVehicleDetail);
        }

        public void Delete(AffairVehicleDetail affairVehicleDetail)
        {
            _vehicleDetailDal.Delete(affairVehicleDetail);
        }

        public AffairVehicleDetail Get(int vehicleDetailId)
        {
            return _vehicleDetailDal.Get(vd => vd.VehicleDetailId == vehicleDetailId);
        }

        public List<AffairVehicleDetail> GetAllById(int affairId)
        {
            return _vehicleDetailDal.GetAll(vd => vd.AffairId == affairId);
        }
        [FluentValidationAspect(typeof(AffairVehicleDetailValidator))]
        public void Update(AffairVehicleDetail affairVehicleDetail)
        {
            _vehicleDetailDal.Update(affairVehicleDetail);
        }
    }
}
