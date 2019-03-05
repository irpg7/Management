using IsKaiser.Management.Core.Entities;
using System;

namespace IsKaiser.Management.Entities.Concrete
{
    public class CustomerAccountant:IEntity
    {
        public int AccountantId { get; set; }
        public int CustomerId { get; set; }
        public string AccountantName { get; set; }
        public string AccountantGsm { get; set; }
        public string AccountantMail { get; set; }
        public string AccountantPhone { get; set; }
        public DateTime AccountantExpiry { get; set; }
    }
}
