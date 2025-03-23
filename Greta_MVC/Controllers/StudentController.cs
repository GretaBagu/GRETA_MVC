using Microsoft.AspNetCore.Mvc;
using Greta_MVC.Data;
using Greta_MVC.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Greta_MVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(Student student)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Student.Add(student); 
                    await _context.SaveChangesAsync();
                    return Content("✅ Duomenys sėkmingai įrašyti į DB!");
                }
                catch (Exception ex)
                {
                    return Content($"❌ Klaida įrašant į duomenų bazę: {ex.Message} <br> 🔍 Išsami klaida: {ex.InnerException?.Message}");
                }
            }
            return View(student);
        }
    }
}