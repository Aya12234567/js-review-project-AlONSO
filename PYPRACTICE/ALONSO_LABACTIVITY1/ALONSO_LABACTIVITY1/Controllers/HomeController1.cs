using Microsoft.AspNetCore.Mvc;
using ALONSO_LABACTIVITY1.Models;

namespace ALONSO_LABACTIVITY1.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            Student pupil = new Student()
            {
                Id = 1,
                Name = "Christopher Columbus",
                Course = "BSIT"
                

            };
            return View(pupil);
        }
    }
}
