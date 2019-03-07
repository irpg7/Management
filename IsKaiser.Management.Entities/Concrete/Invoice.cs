using IsKaiser.Management.Core.Entities;
using System;

namespace IsKaiser.Management.Entities.Concrete
{
    public class Invoice:IEntity
    {
        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }
        public short InvoiceType { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string Serie { get; set; }
        public int Number { get; set; }
        public short TaxRate { get; set; }
        public short WithholdingRate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TaxAmount { get; set; }
    }
}
