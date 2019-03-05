using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.Abstract
{
    public interface IInvoiceService
    {
        void Add(Invoice invoice);
        void Update(Invoice invoice);
        List<Invoice> GetList();
        Invoice Get(int id);
    }
}
