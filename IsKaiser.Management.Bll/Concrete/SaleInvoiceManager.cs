using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.Concrete
{
    public class SaleInvoiceManager : ISaleInvoiceService
    {
        ISaleInvoiceDal _saleInvoiceDal;

        public SaleInvoiceManager(ISaleInvoiceDal saleInvoiceDal)
        {
            _saleInvoiceDal = saleInvoiceDal;
        }

        public void Add(SaleInvoice saleInvoice)
        {
            _saleInvoiceDal.Add(saleInvoice);
        }

        public SaleInvoice Get(int invoiceId)
        {
            return _saleInvoiceDal.Get(si => si.InvoiceId == invoiceId);
        }
    }
}
