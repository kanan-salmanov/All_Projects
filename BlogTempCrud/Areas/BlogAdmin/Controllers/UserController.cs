using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogTempCrud.DAL;
using Microsoft.AspNetCore.Mvc;
using BlogTempCrud.Models;
using BlogTempCrud.ViewModels;

namespace BlogTempCrud.Areas.BlogAdmin.Controllers
{
    [Area("BlogAdmin")]
    public class UserController : Controller
    {

        private AppDbContext _context;
        public UserController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Users.ToList());
        }

        public IActionResult AddUser()
        {
            UserStatusModels userStatusModel = new UserStatusModels
            {
                Statuses = _context.Statuses.ToList()
            };
            return View(userStatusModel);
        }

        [HttpPost]
        public IActionResult AddUser(User user,string RePassword)
        {
            UserStatusModels userStatusModel = new UserStatusModels
            {
                Statuses = _context.Statuses.ToList()
            };
            var emailUser = _context.Users.FirstOrDefault(x => x.Email == user.Email);
            if (ModelState.IsValid && emailUser==null)
            {
               
                if (user.Password == RePassword)
                {
                    user.Password = Crypto.Hash(user.Password);
                    _context.Users.Add(user);
                    _context.SaveChanges();
                    ViewData["Name"] = " ";
                    return RedirectToAction("Index", "User");                    
                }
                else {
                    ViewData["Name"] = "Parol duzgun yazilmayib";
                    
                    return View(userStatusModel);
                }
            }
            ViewData["ErrorMessage"] = "Yazdığınız Email artıq istifadə olunub";
            return View(userStatusModel);
        }

        public async Task<ActionResult> UpdateUser(int? id)
        {
            if (id == null) return NotFound();
            User user = await _context.Users.FindAsync(id);
            if (user == null) return NotFound();
            UserStatusModels userStatusModel = new UserStatusModels
            {
                Users = _context.Users.FirstOrDefault(),
                Statuses = _context.Statuses.ToList()
            };

            return View(userStatusModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> UpdateUser(User user, string NewPassword)
        {

            UserStatusModels userStatusModel = new UserStatusModels
            {
                Users = _context.Users.FirstOrDefault(),
                Statuses = _context.Statuses.ToList()
            };
            var dbUser = await _context.Users.FindAsync(user.Id);
            if (ModelState.IsValid && user != null)
            {
                dbUser.Name = user.Name;
                dbUser.Lastname = user.Lastname;
                dbUser.Email = user.Email;
                if (dbUser.Password == Crypto.Hash(user.Password))
                {
                    dbUser.Password = Crypto.Hash(NewPassword);

                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    return View(userStatusModel);
                }
            }
            else
                return View(userStatusModel);
        }




        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            User user = await _context.Users.FindAsync(id);
            if (user == null) return NotFound();
            return View(user);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            User user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}