using IsKaiser.Management.Core.Entities;
using System;

namespace IsKaiser.Management.Entities.Concrete
{
    public class AffairVehicleDetail:IEntity
    {
        public int VehicleDetailId { get; set; }
        public int AffairId { get; set; }
        public int VehicleId { get; set; }
        public DateTime WorkingIn { get; set; }
        public DateTime WorkingOut { get; set; }
        public DateTime WorkingBreak { get; set; }
        public DateTime WorkingTotal { get; set; }
        public DateTime Total { get; set; }
        public string Note { get; set; }
    }
}
