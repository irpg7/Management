using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.Concrete
{
    public class InvoiceLineManager : IInvoiceLineService
    {
        IInvoiceLineDal _invoiceLineDal;

        public InvoiceLineManager(IInvoiceLineDal invoiceLineDal)
        {
            _invoiceLineDal = invoiceLineDal;
        }

        public void Add(InvoiceLine invoiceLine)
        {
            _invoiceLineDal.Add(invoiceLine);
        }

        public List<InvoiceLine> GetLines(int invoiceId)
        {
            return _invoiceLineDal.GetAll(il => il.InvoiceId == invoiceId);
        }
    }
}
