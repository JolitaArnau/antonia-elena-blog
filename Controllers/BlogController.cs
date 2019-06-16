using Microsoft.AspNetCore.Mvc;

namespace Antonia_Elena_Blog.Controllers
{
    public class BlogController : Controller
    {
        [Route("blog/all")]
        public IActionResult All()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

    }
}