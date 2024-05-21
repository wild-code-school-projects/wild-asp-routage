using Microsoft.AspNetCore.Mvc;

namespace Routage.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/{controller}/Say")]
        public IActionResult SayHello()
        {
            return Content("Say");
        }

        [Route("/{controller}/Yell")]
        public IActionResult YellHello()
        {
            return Content("Yell");
        }

        [Route("Hello")]
        public IActionResult Hello()
        {
            return Content("Say");
        }

        [Route("Yell")]
        public IActionResult Yell()
        {
            return Content("Yell");
        }
    }
}