using IsKaiser.Management.Core.Entities;
using System;

namespace IsKaiser.Management.Entities.Concrete
{
    public class ProductType:IEntity
    {
        public int TypeId { get; set; }
        public string Type { get; set; }
    }
}
