using System.Diagnostics;
using Antonia_Elena_Blog.Data;
using Microsoft.AspNetCore.Mvc;
using Antonia_Elena_Blog.Models;
using Microsoft.AspNetCore.Identity;

namespace Antonia_Elena_Blog.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(UserManager<User> userManager, SignInManager<User> signInManager, ApplicationDbContext dbContext
        ) : base(
            userManager, signInManager, dbContext)
        {
        }
        
        [Route("home")]
        [Route("/")]
        public IActionResult Index()
        {
            var user = userManager.GetUserAsync(User).Result;

            if (signInManager.IsSignedIn(User) &&
                userManager.IsInRoleAsync(user, "Administrator").Result)
            {
                return this.RedirectToAction("Dashboard", "Admin", new {area = "Admin"});
            }

            
            return View();
        }

        [Route("about")]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        
        [Route("books")]
        public IActionResult Books()
        {
            return View();
        }
        
        [Route("partners")]
        public IActionResult Partners()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}