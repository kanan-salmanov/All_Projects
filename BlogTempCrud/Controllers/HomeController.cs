using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BlogTempCrud.DAL;
using BlogTempCrud.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BlogTempCrud.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeModels homeModel = new HomeModels
            {
               Sliders = _context.Sliders.ToList(),
               BlogDatas = _context.BlogDatas.LastOrDefault(),
               Users = _context.Users.ToList(),
               Statuses = _context.Statuses.ToList()
            };
            return View(homeModel);
        }
        
       
    }
}