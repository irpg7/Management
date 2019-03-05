using IsKaiser.Management.Core.Entities;
using System;
using System.Linq;

namespace IsKaiser.Management.Entities.Concrete
{
    public class Employee:IEntity
    {
        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeLastName { get; set; }
        public int? EmployeeTeamId { get; set; }
    }
}
