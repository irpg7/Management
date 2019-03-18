using FluentValidation;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.ValidationRules.FluentValidation
{
    public class InvoiceValidator:AbstractValidator<Invoice>
    {
        public InvoiceValidator()
        {
            RuleFor(i => i.CustomerId).NotEmpty().OverridePropertyName("Müşteri");
            RuleFor(i => i.InvoiceDate).NotEmpty().OverridePropertyName("Evrak Tarihi");
            RuleFor(i => i.ExpiryPeriod).NotEmpty().OverridePropertyName("Vade");
            RuleFor(i => i.Number).NotEmpty().OverridePropertyName("Evrak Sıra No");
            RuleFor(i => i.Serie).NotEmpty().OverridePropertyName("Evrak Seri");
            RuleFor(i=>i.TaxRate).NotEmpty().OverridePropertyName("KDV Oranı");
            RuleFor(i => i.WithholdingRate).GreaterThanOrEqualTo((short)0).OverridePropertyName("Tevkifat Oranı");
            RuleFor(i => i.WaybillNumber).NotEmpty().OverridePropertyName("İrsaliye No.");
            RuleFor(i => i.TotalAmount).NotEmpty().OverridePropertyName("Fiyat");
        }
    }
}
