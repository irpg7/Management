using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Entities.Concrete;
using IsKaiser.Management.WebUI.Models;
using IsKaiser.Management.WebUI.Utilities.FileConverter.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IsKaiser.Management.WebUI.Controllers
{

    public class AffairsController : Controller
    {
        IAffairService _affairService;
        ICustomerService _customerService;
        IEmployeeService _employeeService;
        IVehicleService _vehicleService;
        IConverter _converter;
        public AffairsController(IAffairService affairService, ICustomerService customerService, 
            IEmployeeService employeeService, IVehicleService vehicleService,IConverter converter)
        {
            _affairService = affairService;
            _customerService = customerService;
            _employeeService = employeeService;
            _vehicleService = vehicleService;
            _converter = converter;
        }

        public IActionResult Index()
        {
            var model = new AffairListViewModel
            {

                AffairList = _affairService.GetAffairList()
            };
            return View(model);
        }
        public IActionResult New()
        {
            var model = new NewAffairViewModel
            {
                Customers = _customerService.GetAll(),
                Employees = _employeeService.GetAll(),
                Vehicles = _vehicleService.GetAll(),
                Affair = new Affair(),
                AffairDetail = new AffairDetail(),
                AffairEmployeeDetail = new AffairEmployeeDetail(),
                AffairVehicleDetail = new AffairVehicleDetail()

            };
            return View(model);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult New(Affair affair, AffairDetail affairDetail, List<AffairEmployeeDetail> affairEmployeeDetail,
            List<AffairVehicleDetail> affairVehicleDetail)
        {
            string customerSignName = affairDetail.SignatureDate.ToShortDateString() + affairDetail.CustomerInfo+".svg";
            string customerBase64 = affairDetail.CustomerSignaturePath.Replace("data:image/svg+xml;base64,", "");
            _converter.ConvertFile(customerSignName, customerBase64);
            affairDetail.CustomerSignaturePath = customerSignName;
            string employeeSignName = affairDetail.SignatureDate.ToShortDateString() + affairDetail.EmployeeId + ".svg";
            string employeeBase64 = affairDetail.SignaturePath.Replace("data:image/svg+xml;base64,", "");
            _converter.ConvertFile(employeeSignName, employeeBase64);
            affairDetail.SignaturePath = employeeSignName;
            
            return RedirectToAction(nameof(Index));
        }
        
    }
}
