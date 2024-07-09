using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.data;
using WebApplication1.models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    public class logincontroller : Controller
    {
        private readonly appdbcontext _context;

        public logincontroller(appdbcontext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> login(personel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _context.Personeller
                    .FirstOrDefaultAsync(u => u.TcKimlikNumarasi == model.TcKimlikNumarasi && u.Password == model.Password);

                if (user != null)
                {
                    // نجاح تسجيل الدخول
                    return RedirectToAction("success");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "اسم المستخدم أو كلمة المرور غير صحيحة");
                }
            }
            return View(model);
        }

        public IActionResult success()
        {
            return View();
        }
    }
}
