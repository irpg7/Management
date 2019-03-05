using IsKaiser.Management.Bll.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsKaiser.Management.WinUI.Utilities
{
    public interface IExcelImporter
    {
        void ImportXl(string path, ICustomerService customerService);
    }
}
