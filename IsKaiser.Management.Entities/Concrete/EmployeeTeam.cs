using IsKaiser.Management.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsKaiser.Management.Entities.Concrete
{
    public class EmployeeTeam:IEntity
    {
        [Key]
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public int TeamLeaderId { get; set; }
    }
}
