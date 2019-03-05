using IsKaiser.Management.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Entities.Concrete
{
    public class Vehicle:IEntity
    {
        public int VehicleId { get; set; }
        public string VehiclePlate { get; set; }
        public short VehicleType { get; set; }
    }
}
