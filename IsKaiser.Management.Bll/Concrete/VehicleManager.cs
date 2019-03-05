using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Bll.Utilities;
using IsKaiser.Management.Bll.ValidationRules.FluentValidation;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.Concrete
{
    public class VehicleManager : IVehicleService
    {
        IVehicleDal _vehicleDal;

        public VehicleManager(IVehicleDal vehicleDal)
        {
            _vehicleDal = vehicleDal;
        }

        public void Add(Vehicle vehicle)
        {
            ValidationTool.Validate(new VehicleValidator(), vehicle);
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

        public void Update(Vehicle vehicle)
        {
            ValidationTool.Validate(new VehicleValidator(), vehicle);
            _vehicleDal.Update(vehicle);
        }
    }
}
