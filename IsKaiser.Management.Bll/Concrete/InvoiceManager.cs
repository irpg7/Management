using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Bll.ValidationRules.FluentValidation;
using IsKaiser.Management.Core.Aspects.Postsharp.ValidationAspects;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsKaiser.Management.Bll.Concrete
{
    public class InvoiceManager : IInvoiceService
    {
        IInvoiceDal _invoiceDal;

        public InvoiceManager(IInvoiceDal invoiceDal)
        {
            _invoiceDal = invoiceDal;
        }
        [FluentValidationAspect(typeof(InvoiceValidator))]
        public void Add(Invoice invoice)
        {
            _invoiceDal.Add(invoice);
        }

        public Invoice Get(int id)
        {
            return _invoiceDal.Get(i => i.InvoiceId == id);
        }

        public List<Invoice> GetList()
        {
            return _invoiceDal.GetAll();
        }
        [FluentValidationAspect(typeof(InvoiceValidator))]
        public void Update(Invoice invoice)
        {
            _invoiceDal.Update(invoice);
        }
    }
}
