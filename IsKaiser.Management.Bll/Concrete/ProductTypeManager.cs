using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.Concrete
{
    public class ProductTypeManager : IProductTypeService
    {
        IProductTypeDal _productTypeDal;

        public ProductTypeManager(IProductTypeDal productTypeDal)
        {
            _productTypeDal = productTypeDal;
        }

        public void Add(ProductType productType)
        {
            _productTypeDal.Add(productType);
        }

        public void Delete(ProductType productType)
        {
            _productTypeDal.Delete(productType);
        }

        public ProductType Get(int id)
        {
            return _productTypeDal.Get(pt => pt.TypeId == id);
        }

        public ProductType GetByName(string typeName)
        {
            return _productTypeDal.Get(pt => pt.Type.ToLower() == typeName.ToLower());
        }

        public List<ProductType> GetList()
        {
            return _productTypeDal.GetAll();
        }

        public void Update(ProductType productType)
        {
            _productTypeDal.Update(productType);
        }
    }
}
