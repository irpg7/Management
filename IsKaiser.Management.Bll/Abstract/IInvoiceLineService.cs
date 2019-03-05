using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.Abstract
{
    public interface IInvoiceLineService
    {
        void Add(InvoiceLine invoiceLine);
        List<InvoiceLine> GetLines(int invoiceId);

    }
}
