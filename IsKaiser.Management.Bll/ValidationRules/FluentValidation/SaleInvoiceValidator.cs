﻿using FluentValidation;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.ValidationRules.FluentValidation
{
    public class SaleInvoiceValidator:AbstractValidator<SaleInvoice>
    {
        public SaleInvoiceValidator()
        {
            RuleFor(si => si.OrderDate).NotEmpty().OverridePropertyName("Sipariş Tarihi");
            RuleFor(si => si.OrderedBy).NotEmpty().OverridePropertyName("Sipariş Veren").MaximumLength(50);
            RuleFor(si => si.OrderNo).NotEmpty().OverridePropertyName("Sipariş No").MaximumLength(50);
            RuleFor(si => si.RefNumber).NotEmpty().OverridePropertyName("Ref.No").MaximumLength(25);
            RuleFor(si => si.RequestedBy).NotEmpty().OverridePropertyName("Talep Eden").MaximumLength(50);
        }
    }
}
