using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsKaiser.Management.WebUI.Models
{
    public class UpdateAffairViewModel
    {
        public Affair Affair { get; set; }
        public AffairDetail AffairDetail { get; set; }
        public AffairEmployeeDetail AffairEmployeeDetail { get; set; }
        public AffairVehicleDetail AffairVehicleDetail { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}
