using IsKaiser.Management.Core.Entities;
using System;
using System.Linq;

namespace IsKaiser.Management.Entities.Concrete
{
    public class EmployeeTeam:IEntity
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public int TeamLeaderId { get; set; }
    }
}
