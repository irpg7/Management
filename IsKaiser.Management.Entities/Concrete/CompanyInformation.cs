using IsKaiser.Management.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Entities.Concrete
{
    public class CompanyInformation:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string TaxDepartment { get; set; }
        public string TaxNo { get; set; }
        
    }
}
