using Microsoft.AspNetCore.Mvc;

namespace ALONSO_LABACTIVITY2.Models
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
