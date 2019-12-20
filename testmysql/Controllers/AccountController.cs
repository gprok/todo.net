using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using testmysql.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace testmysql.Controllers
{
    public class AccountController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            TodoDB db = new TodoDB();

            var list = db.accountEntity.ToList();

            ViewBag.AccountList = list;

            return View();
        }

        public IActionResult Login()
        {
            if (TempData["error"] != null)
                ViewBag.error = TempData["error"].ToString();
            return View();
        }

  
        [HttpPost]
        public IActionResult LoginCheck(string email, string password)
        {
            if (email != null && password != null)
            {
                TodoDB db = new TodoDB();
                var acc = db.accountEntity.Where(a => a.email == email && a.password == password).FirstOrDefault<Account>();
                if(acc == null) 
                {
                    TempData["error"] = "Invalid Account " + email + " - " + password;
                    return RedirectToAction("Login");
                }

                HttpContext.Session.SetString("email", email);
                // return RedirectToAction("Todo");

                return RedirectToAction("Index", "Todo");
            }
            else
            {
                TempData["error"] = "Both fields needed";
  
                return RedirectToAction("Login");
            }
        }

    }
}
