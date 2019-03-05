using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace IsKaiser.Management.Bll.Abstract
{
    public interface IProductService
    {
        void Add(Product product);
        void Update(Product product);
        List<Product> GetList();
        Product Get(int id);
    }
}
