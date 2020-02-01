using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    public class SliderController : Controller
    {

        private AppDbContext _context;
        public SliderController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Sliders.ToList());
        }

        public IActionResult AddSlider()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSlider(Slider slider, IFormFile image)
        {


            if (ModelState.IsValid )
            {
               
                //image upload
                var fileName = Path.GetFileNameWithoutExtension(image.FileName);
                var fileExtension = Path.GetExtension(image.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmddffff") + fileExtension;
                fileName = Path.Combine("wwwroot/images/Slider/", fileName);
                var stream = new FileStream(fileName, FileMode.Create);
                image.CopyTo(stream);
                //image upload


                slider.Image = fileName;
                _context.Sliders.Add(slider);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                return View();
        }



        public async Task<ActionResult> UpdateSlider(int? id)
        {
            if (id == null) return NotFound();
            Slider slider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            return View(slider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> UpdateSlider(Slider slider, IFormFile image)
        {

            var dbSlider = await _context.Sliders.FindAsync(slider.Id);
            if (ModelState.IsValid)
            {
                //image upload
                var fileName = Path.GetFileNameWithoutExtension(image.FileName);
                var fileExtension = Path.GetExtension(image.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmddffff") + fileExtension;
                fileName = Path.Combine("wwwroot/images/Slider/", fileName);
                var stream = new FileStream(fileName, FileMode.Create);
                image.CopyTo(stream);
                //image upload
                
                slider.Image = fileName;
                dbSlider.Title = slider.Title;
                dbSlider.Description = slider.Description;
                dbSlider.Image = slider.Image;

                
                await _context.SaveChangesAsync();
                return RedirectToAction("Index","Slider");
            }
            else
                return RedirectToAction("UpdateSlider","Slider");
        }

    
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            Slider slider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            return View(slider);
        }
        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Slider slider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            return View(slider);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            Slider slider = await _context.Sliders.FindAsync(id);
            _context.Sliders.Remove(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        
    }
}