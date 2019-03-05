using IsKaiser.Management.WebUI.Utilities.FileConverter.Abstract;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IsKaiser.Management.WebUI.Utilities.FileConverter.Concrete
{
    public class SvgConverter : IConverter
    {
        IHostingEnvironment _hostingEnvironment;

        public SvgConverter(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public void ConvertFile(string fileName,string base64)
        {
            string directoryPath = _hostingEnvironment.ContentRootPath + "\\Signatures\\";
            var base64Array = Convert.FromBase64String(base64);
            if (Directory.Exists(directoryPath))
            {
                File.WriteAllBytes(directoryPath + fileName, base64Array);
            }
            else
            {
                Directory.CreateDirectory(directoryPath);
                File.WriteAllBytes(directoryPath + fileName, base64Array);
            }
           
        }
    }
}
