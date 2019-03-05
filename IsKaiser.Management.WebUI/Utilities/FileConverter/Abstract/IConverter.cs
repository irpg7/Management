using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsKaiser.Management.WebUI.Utilities.FileConverter.Abstract
{
    public interface IConverter
    {
        void ConvertFile(string fileName,string base64);
    }
}
