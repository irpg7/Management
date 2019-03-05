using IsKaiser.Management.Core.Entities;
using System;

namespace IsKaiser.Management.Entities.Concrete
{
    public class Vehicle:IEntity
    {
        public int VehicleId { get; set; }
        public string VehiclePlate { get; set; }
        public short VehicleType { get; set; }
    }
}
