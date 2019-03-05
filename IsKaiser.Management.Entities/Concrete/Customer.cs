using IsKaiser.Management.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsKaiser.Management.Entities.Concrete
{
    public class Customer:IEntity
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string CustomerTaxNo { get; set; }
        public string CustomerTaxDepartment { get; set; }
        public string CustomerAddress { get; set; }
        public bool CustomerActive { get; set; }
        public bool CustomerDebated { get; set; }
        public bool CustomerGotAppointment { get; set; }
        public int CustomerEnvoyId { get; set; }
    }
}
