using IsKaiser.Management.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsKaiser.Management.Entities.Concrete
{
    public class Employee:IEntity
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeLastName { get; set; }
        public int? EmployeeTeamId { get; set; }
    }
}
