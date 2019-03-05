using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Core.Aspects.Postsharp.ValidationAspects;
using IsKaiser.Management.Bll.ValidationRules.FluentValidation;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        [FluentValidationAspect(typeof(ProductValidator))]
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public Product Get(int id)
        {
           return _productDal.Get(p => p.ProductId == id);
        }

        public List<Product> GetList()
        {
            return _productDal.GetAll();
        }
        [FluentValidationAspect(typeof(ProductValidator))]
        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
