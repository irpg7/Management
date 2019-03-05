using IsKaiser.Management.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsKaiser.Management.Entities.Concrete
{
    public class Appointment:IEntity
    {
       [Key]
        public int AppointmentId { get; set; }
        public int CustomerId { get; set; }
        public int EnvoyId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string AppointmentDetail { get; set; }
    }
}
