using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class Basvur : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
