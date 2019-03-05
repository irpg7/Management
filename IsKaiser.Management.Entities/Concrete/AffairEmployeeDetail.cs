using IsKaiser.Management.Core.Entities;
using System;

namespace IsKaiser.Management.Entities.Concrete
{
    public class AffairEmployeeDetail:IEntity
    {
        public int EmployeeDetailId { get; set; }
        public int AffairId { get; set; }
        public int EmployeeId { get; set; }
        public int Role { get; set; }
        public DateTime WorkingIn { get; set; }
        public DateTime WorkingOut { get; set; }
        public DateTime BreakTime { get; set; }
        public DateTime NetWorkingTime { get; set; }
        public DateTime Total { get; set; }
    }
}
