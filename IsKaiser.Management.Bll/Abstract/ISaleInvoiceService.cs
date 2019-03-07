using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.Abstract
{
    public interface ISaleInvoiceService
    {
        void Add(SaleInvoice saleInvoice);
        SaleInvoice Get(int invoiceId);
    }
}
