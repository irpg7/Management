using IsKaiser.Management.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Entities.Concrete
{
    public class SaleInvoice:IEntity
    {
        public int SaleId { get; set; }
        public int InvoiceId { get; set; }
        public string RefNumber { get; set; }
        public short ExpiryDate { get; set; }
        public string RequestedBy { get; set; }
        public string OrderedBy { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderNo { get; set; }
    }
}
