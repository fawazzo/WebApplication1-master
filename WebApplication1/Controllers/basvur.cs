using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class basvur : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
