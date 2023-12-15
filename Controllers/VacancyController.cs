using Microsoft.AspNetCore.Mvc;

namespace App_GPO.Controllers
{
    public class VacancyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
