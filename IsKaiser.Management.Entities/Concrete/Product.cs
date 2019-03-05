using IsKaiser.Management.Core.Entities;
using System;

namespace IsKaiser.Management.Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public short ProductType { get; set; }
        public string ProductDescription { get; set; }

    }
}
