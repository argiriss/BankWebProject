using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebBankProject.Models.Services;

namespace WebBankProject.Controllers
{
    public class AdminController : Controller
    {
        //this added by dio ..................................................
        //use this to all controllers where needed access to users records
        //repository bellow is a list of all users
        private IUserRepository repository;
        //constructor
        //from startup depedency injection 
        //services.AddTransient<IUserRepository, EFUserRepository>();
        public AdminController(IUserRepository rep)
        {
            repository = rep;
        }
        //end of Dio.................................................

        public IActionResult ViewInternal()
        {
            //we return an object IUserRepository which has a property of an IQueryable 
            //with users
            return View(repository);
          
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