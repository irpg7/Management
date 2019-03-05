using IsKaiser.Management.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsKaiser.Management.Entities.Concrete
{
    public class CustomerAccountant:IEntity
    {
        [Key]
        public int AccountantId { get; set; }
        public int CustomerId { get; set; }
        public string AccountantName { get; set; }
        public string AccountantGsm { get; set; }
        public string AccountantMail { get; set; }
        public string AccountantPhone { get; set; }
        public DateTime AccountantExpiry { get; set; }
    }
}
