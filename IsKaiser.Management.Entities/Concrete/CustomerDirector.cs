using IsKaiser.Management.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsKaiser.Management.Entities.Concrete
{
    public class CustomerDirector:IEntity
    {
        [Key]
        public int DirectorId { get; set; }
        public int CustomerId { get; set; }
        public string DirectorName { get; set; }
        public string DirectorTitle { get; set; }
        public string DirectorGsm { get; set; }
        public string DirectorMail { get; set; }
        public string DirectorPhone { get; set; }
    }
}
