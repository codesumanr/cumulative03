using Microsoft.AspNetCore.Mvc;

namespace cumulative01.Controllers
{
    public class StudentAjaxPageController : Controller
    { 

        public IActionResult List()
        {
            return View();
        }

        public IActionResult New()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}

