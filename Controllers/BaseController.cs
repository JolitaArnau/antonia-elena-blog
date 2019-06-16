using Antonia_Elena_Blog.Data;
using Antonia_Elena_Blog.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Antonia_Elena_Blog.Controllers
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