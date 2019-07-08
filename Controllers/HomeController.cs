using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Your_Blog_Template.Data;
using Your_Blog_Template.Models;

namespace Your_Blog_Template.Controllers
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
        
        [Route("products")]
        public IActionResult Products()
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