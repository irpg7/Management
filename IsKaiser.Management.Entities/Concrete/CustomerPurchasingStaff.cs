using IsKaiser.Management.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsKaiser.Management.Entities.Concrete
{
    public class CustomerPurchasingStaff:IEntity
    {
        [Key]
        public int PurchaseStaffId { get; set; }
        public int CustomerId { get; set; }
        public string PurchaseStaffName { get; set; }
        public string PurchaseStaffGsm { get; set; }
        public string PurchaseStaffMail { get; set; }
        public string PurchaseStaffPhone { get; set; }

    }
}
