using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class loginController : Controller
    {
        public IActionResult login()
        {
            return View();
        }
    }
}
