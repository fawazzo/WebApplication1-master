using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.data;
using WebApplication1.models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        private readonly AppDbContext _context;

        public LoginController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(personel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _context.Personeller
                    .FirstOrDefaultAsync(u => u.TcKimlikNumarasi == model.TcKimlikNumarasi && u.Password == model.Password);

                if (user != null)
                {
                    // Successful login
                    return RedirectToAction("Success");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Incorrect username or password");
                }
            }
            return View(model);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
