using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebBankProject.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult ViewInternal()
        {
            return View();
        }

        public IActionResult ViewAny()
        {
            return View();
        }

        public IActionResult Deposit()
        {
            return View();
        }

        public IActionResult Withdraw()
        {
            return View();
        }

        public IActionResult AddFile()
        {
            return View();
        }

    }
}