using IsKaiser.Management.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsKaiser.Management.Entities.Concrete
{
    public class User:IEntity
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPw { get; set; }
        public byte UserType { get; set; }
        public int? EmployeeId { get; set; }
    }
}
