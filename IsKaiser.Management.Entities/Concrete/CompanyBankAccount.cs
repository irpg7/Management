using IsKaiser.Management.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Entities.Concrete
{
    public class CompanyBankAccount:IEntity
    {
        public int AccountId { get; set; }
        public int CompanyId { get; set; }
        public string BankName { get; set; }
        public string BranchOffice { get; set; }
        public string LiraIban { get; set; }
        public string EuroIban { get; set; }
        public string DollarIban { get; set; }
        public string SwiftCode { get; set; }
    }
}
