using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Your_Blog_Template.Data;
using Your_Blog_Template.Models;

namespace Your_Blog_Template.Controllers
{
    public class BaseController : Controller
    {
        protected readonly UserManager<User> userManager;
        protected readonly SignInManager<User> signInManager;
        protected readonly ApplicationDbContext dbContext;

        public BaseController(UserManager<User> userManager, SignInManager<User> signInManager,
            ApplicationDbContext dbContext)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.dbContext = dbContext;
        }
    }
}