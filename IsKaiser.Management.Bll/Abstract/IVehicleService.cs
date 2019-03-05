using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace IsKaiser.Management.Bll.Abstract
{
    public interface IVehicleService
    {
        List<Vehicle> GetAll();
        Vehicle Get(int id);
        void Add(Vehicle vehicle);
        void Update(Vehicle vehicle);
        void Delete(Vehicle vehicle);
    }
}
