using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebBankProject.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

<<<<<<< Updated upstream
        public IActionResult DepositToAdmin()
        {
            return View();
        }

        public IActionResult DepositToUser()
        {
            return View();
        }

        public IActionResult SendStatement()
        {
            return View();
        }

        public IActionResult ViewAccount()
        {
            return View();
        }






=======
>>>>>>> Stashed changes

    }
}