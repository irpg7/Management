using FluentValidation;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.ValidationRules.FluentValidation
{
    public class ProductTypeValidator:AbstractValidator<ProductType>
    {
        public ProductTypeValidator()
        {
            RuleFor(pt => pt.Type).NotEmpty().OverridePropertyName("Ürün Tipi");
        }
    }
}
