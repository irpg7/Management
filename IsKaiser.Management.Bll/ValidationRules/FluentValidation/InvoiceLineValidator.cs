using FluentValidation;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.ValidationRules.FluentValidation
{
    public class InvoiceLineValidator:AbstractValidator<InvoiceLine>
    {
        public InvoiceLineValidator()
        {
            RuleFor(il => il.ProductId).NotEmpty().OverridePropertyName("Ürün");
            RuleFor(il => il.Quantity).NotEmpty().OverridePropertyName("Miktar");
            RuleFor(il => il.UnitPrice).NotEmpty().OverridePropertyName("Fiyat");
        }
    }
}
