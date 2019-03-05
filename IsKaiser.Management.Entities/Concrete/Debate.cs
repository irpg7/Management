using IsKaiser.Management.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace IsKaiser.Management.Entities.Concrete
{
    public class Debate:IEntity
    {
        [Key]
        public int DebateId { get; set; }
        public int CustomerId { get; set; }
        public int EnvoyId { get; set; }
        public int TeamId { get; set; }
        public DateTime DebateDate { get; set; }
        public string DebateDetail { get; set; }
        public string DebateRequiredEquipment { get; set; }
        public string DebateSecurityDetail { get; set; }
        public string DebateRequested { get; set; }
    }
}
