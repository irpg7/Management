using IsKaiser.Management.Core.Entities;
using System;
using System.Linq;

namespace IsKaiser.Management.Entities.Concrete
{
    public class User:IEntity
    {
        
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPw { get; set; }
        public byte UserType { get; set; }
        public int? EmployeeId { get; set; }
    }
}
