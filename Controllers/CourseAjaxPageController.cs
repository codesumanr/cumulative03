using Microsoft.AspNetCore.Mvc;

namespace cumulative01.Controllers
{
    public class CourseAjaxPageController : Controller
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


