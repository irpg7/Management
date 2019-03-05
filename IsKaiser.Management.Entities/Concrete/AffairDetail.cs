using IsKaiser.Management.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Entities.Concrete
{
    public class AffairDetail:IEntity
    {
        public int AffairDetailId { get; set; }
        public int AffairId { get; set; }
        public string BreakCausedBy { get; set; }
        public DateTime BreakBeginTime { get; set; }
        public DateTime BreakEndTime { get; set; }
        public DateTime TotalBreakTime { get; set; }
        public string EquipmentUsed { get; set; }
        public DateTime SignatureDate { get; set; }
        public int EmployeeId { get; set; }
        public string SignaturePath { get; set; }
        public string CustomerAgreement { get; set; }
        public string CustomerInfo { get; set; }
        public string CustomerSignaturePath { get; set; }
    }
}
