using IsKaiser.Management.Core.Entities;
using System;
using System.Linq;

namespace IsKaiser.Management.Entities.Concrete
{
    public class CustomerDirector:IEntity
    {
        public int DirectorId { get; set; }
        public int CustomerId { get; set; }
        public string DirectorName { get; set; }
        public string DirectorTitle { get; set; }
        public string DirectorGsm { get; set; }
        public string DirectorMail { get; set; }
        public string DirectorPhone { get; set; }
    }
}
