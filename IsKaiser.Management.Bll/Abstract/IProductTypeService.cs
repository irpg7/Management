using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.Abstract
{
    public interface IProductTypeService
    {
        void Add(ProductType productType);
        void Update(ProductType productType);
        void Delete(ProductType productType);
        List<ProductType> GetList();
        ProductType Get(int id);
        ProductType GetByName(string typeName);
    }
}
