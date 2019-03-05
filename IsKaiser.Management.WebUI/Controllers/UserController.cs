using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IsKaiser.Management.Bll.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace IsKaiser.Management.WebUI.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService;
       public UserController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string UserName,string Password)
        {
            if (ModelState.IsValid)
            {
                if (_userService.CheckUser(UserName, Password) != null)
                {
                    return RedirectToAction("Index", "Affairs");
                }
            }
            return View();
        }
    }
}