using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Your_Blog_Template.Areas.Admin.ViewModels;
using Your_Blog_Template.Data;
using Your_Blog_Template.Models;

namespace Your_Blog_Template.Controllers
{
    public class BlogController : BaseController
    {
        private readonly IMapper mapper;

        public BlogController(UserManager<User> userManager, SignInManager<User> signInManager,
            ApplicationDbContext dbContext, IMapper mapper
        ) : base(
            userManager, signInManager, dbContext)
        {
            this.mapper = mapper;
        }


        [Route("blog/all")]
        public async Task<IActionResult> All()
        {
            var posts = await this.dbContext.BlogPosts.ToArrayAsync();

            var blogPostViewModel = this.mapper.Map<BlogPost[], IEnumerable<BlogPostBindingModel>>(posts)
                .OrderBy(d => d.CreatedOn);

            return this.View(blogPostViewModel);
        }

        [HttpGet]
        [Route("blog/details/{id}")]
        public async Task<IActionResult> Details(BlogPostBindingModel model)
        {
            var blogPost = await this.dbContext.BlogPosts.FirstOrDefaultAsync(bp => bp.Id.Equals(model.Id));

            var blogPostViewModel = this.mapper.Map<BlogPost, BlogPostBindingModel>(blogPost);

            return View(blogPostViewModel);
        }

        [HttpGet]
        [Route("blog/recipes")]
        public async Task<IActionResult> Recipes(BlogPostBindingModel model)
        {
            return ViewComponent("Recipes");
        }
        
        [HttpGet]
        [Route("blog/travelling")]
        public async Task<IActionResult> Travelling(BlogPostBindingModel model)
        {
            return ViewComponent("Travelling");
        }
        
        [HttpGet]
        [Route("blog/thoughts")]
        public async Task<IActionResult> Thoughts(BlogPostBindingModel model)
        {
            return ViewComponent("Thoughts");
        }
    }
}