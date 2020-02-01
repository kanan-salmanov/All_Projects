using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BlogTempCrud.DAL;
using BlogTempCrud.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogTempCrud.Areas.BlogAdmin.Controllers
{
    [Area("BlogAdmin")]
    public class BlogDataController : Controller
    {
        
        private AppDbContext _context;
        public BlogDataController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View(_context.BlogDatas.ToList());
        }


        public IActionResult AddBlogData()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBlogData(BlogData blogData, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                //image upload
                var fileName = Path.GetFileNameWithoutExtension(image.FileName);
                var fileExtension = Path.GetExtension(image.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmddffff") + fileExtension;
                fileName = Path.Combine("wwwroot/images/", fileName);
                var stream = new FileStream(fileName, FileMode.Create);
                image.CopyTo(stream);
                //image upload
                blogData.Time = DateTime.Now;
                blogData.UserId = Convert.ToInt32(HttpContext.Session.GetString("LoginId"));
                blogData.Image = fileName;
                _context.BlogDatas.Add(blogData);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                return View();
        }
        public IActionResult UpdateBlogData(int? id)
        {
            if (id == null) return NotFound();
            BlogData blogData = _context.BlogDatas.Find(id);
            if (blogData == null) return NotFound();
            return View(blogData);
        }

        [HttpPost]
        public IActionResult UpdataBlogData(BlogData blogData, IFormFile image)
        {
            var DbBlog = _context.BlogDatas.FirstOrDefault(x => x.Id ==blogData.Id);
            if (ModelState.IsValid && DbBlog!=null)
            {
                //image upload
                var fileName = Path.GetFileNameWithoutExtension(image.FileName);
                var fileExtension = Path.GetExtension(image.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmddffff") + fileExtension;
                fileName = Path.Combine("wwwroot/images/", fileName);
                var stream = new FileStream(fileName, FileMode.Create);
                image.CopyTo(stream);
                //image upload
                DbBlog.Time = DateTime.Now;
                DbBlog.Title = blogData.Title;
                DbBlog.Description = blogData.Description;
                DbBlog.Image = fileName;
                
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                return View();
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            BlogData blogData = await _context.BlogDatas.FindAsync(id);
            if (blogData == null) return NotFound();
            return View(blogData);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            BlogData blogData = await _context.BlogDatas.FindAsync(id);
            if (blogData == null) return NotFound();
            return View(blogData);
        }



        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteBlogData(int? id)
        {
            BlogData blogData = await _context.BlogDatas.FindAsync(id);
            _context.BlogDatas.Remove(blogData);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}