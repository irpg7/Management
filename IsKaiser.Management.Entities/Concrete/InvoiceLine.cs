using IsKaiser.Management.Entities.Abstract;
using System;

namespace IsKaiser.Management.Entities.Concrete
{
    public class InvoiceLine : IEntity
    {
        public int LineId { get; set; }
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public short Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
