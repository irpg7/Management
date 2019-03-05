using FluentValidation;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().OverridePropertyName("Ürün Adı");
            RuleFor(p => p.ProductType).NotEmpty().OverridePropertyName("Ürün Tipi");
        }
    }
}
