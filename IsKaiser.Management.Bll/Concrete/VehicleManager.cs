using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Bll.ValidationRules.FluentValidation;
using IsKaiser.Management.Core.Aspects.Postsharp.ValidationAspects;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System.Collections.Generic;

namespace IsKaiser.Management.Bll.Concrete
{
    public class VehicleManager : IVehicleService
    {
        IVehicleDal _vehicleDal;

        public VehicleManager(IVehicleDal vehicleDal)
        {
            _vehicleDal = vehicleDal;
        }
        [FluentValidationAspect(typeof(VehicleValidator))]
        public void Add(Vehicle vehicle)
        {
            _vehicleDal.Add(vehicle);
        }

        public void Delete(Vehicle vehicle)
        {
            _vehicleDal.Delete(vehicle);
        }

        public Vehicle Get(int id)
        {
            return _vehicleDal.Get(v => v.VehicleId == id);
        }

        public List<Vehicle> GetAll()
        {
            return _vehicleDal.GetAll();
        }
        [FluentValidationAspect(typeof(VehicleValidator))]
        public void Update(Vehicle vehicle)
        {
            _vehicleDal.Update(vehicle);
        }
    }
}
