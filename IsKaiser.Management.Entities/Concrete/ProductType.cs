using IsKaiser.Management.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Entities.Concrete
{
    public class ProductType:IEntity
    {
        public int TypeId { get; set; }
        public string Type { get; set; }
    }
}
