using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using BlogTempCrud.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogTempCrud.Areas.BlogAdmin.Controllers
{
    [Area("BlogAdmin")]
    
    public class DashboardController : Controller
    {
        private AppDbContext _context;
        public DashboardController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("LoginName")!=null)
            {
                ViewBag.SessionName = HttpContext.Session.GetString("LoginName");
            }
            return View();
        }
        [Route("/AdminLogin")]
        public ActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminLogin(string Email,string Password)
        {
            
            var user = _context.Users.FirstOrDefault(x => x.Email == Email);
            Password = Crypto.Hash(Password);
            if (user!=null && user.Password == Password)
            {
                HttpContext.Session.SetString("LoginName", user.Name);
                HttpContext.Session.SetString("LoginId", user.Id.ToString());
                ViewBag.SessionId = HttpContext.Session.GetString("LoginId");
                return RedirectToAction("Index","Dashboard");
            }
            else
            {
                return RedirectToAction("AdminLogin","Dashboard");
            }
           
        }

        public ActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("AdminLogin", "Dashboard");
        }
    }
}