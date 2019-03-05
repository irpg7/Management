using IsKaiser.Management.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Entities.Concrete
{
    public class Affair:IEntity
    {
        public int AffairId { get; set; }
        public int CustomerId { get; set; }
        public int VehicleId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime AffairDate { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Project { get; set; }
        public string ProjectNo { get; set; }
        public int OrderNo { get; set; }
        public string OrderedBy { get; set; }
        public string AffairsMade { get; set; }
    }
}
