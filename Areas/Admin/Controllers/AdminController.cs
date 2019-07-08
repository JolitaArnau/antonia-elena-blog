using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Your_Blog_Template.Areas.Admin.ViewModels;
using Your_Blog_Template.Data;
using Your_Blog_Template.Models;

namespace Your_Blog_Template.Areas.Admin.Controllers
{
    [Authorize(Roles = "Administrator")]
    [Area("Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public AdminController(ApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("admin/dashboard")]
        public IActionResult Dashboard()
        {
            return this.View();
        }

        [HttpGet]
        [Route("admin/all")]
        public async Task<IActionResult> All()
        {
            var posts = await this.dbContext.BlogPosts.ToArrayAsync();

            var blogPostViewModel = this.mapper.Map<BlogPost[], IEnumerable<BlogPostBindingModel>>(posts)
                .OrderBy(d => d.CreatedOn);

            return this.View(blogPostViewModel);
        }

        [HttpGet]
        [Route("admin/drafts")]
        public async Task<IActionResult> Drafts()
        {
            var drafts = await this.dbContext.BlogPosts.Where(bp => bp.IsDraft).ToArrayAsync();

            var draftsViewModel = this.mapper.Map<BlogPost[], IEnumerable<BlogPostBindingModel>>(drafts)
                .OrderBy(d => d.CreatedOn);

            return this.View("Drafts", draftsViewModel);
        }
        
        
        [HttpGet]
        [Route("admin/published")]
        public async Task<IActionResult> Published()
        {
            var publishedPosts = await this.dbContext.BlogPosts.Where(bp => !bp.IsDraft).ToArrayAsync();

            var publishedPostsViewModel = this.mapper.Map<BlogPost[], IEnumerable<BlogPostBindingModel>>(publishedPosts)
                .OrderBy(d => d.CreatedOn);

            return this.View("Published", publishedPostsViewModel);
        }

        [HttpGet]
        [Route("admin/add")]
        public IActionResult Add()
        {
            return this.View();
        }

        [HttpPost]
        [Route("admin/add")]
        public async Task<IActionResult> Add(BlogPostBindingModel model)
        {
            var blogPost = new BlogPost()
            {
                Category = model.Category,
                Title = model.Title,
                Writer = model.Writer,
                ImageUrl = model.ImageUrl,
                Content = model.Content,
                CreatedOn = model.CreatedOn,
                IsDraft = model.IsDraft
            };

            await this.dbContext.BlogPosts.AddAsync(blogPost);
            await this.dbContext.SaveChangesAsync();

            return this.RedirectToAction(blogPost.IsDraft ? "Drafts" : "All");
        }

        [HttpGet]
        [Route("admin/edit/{id}")]
        public async Task<IActionResult> Edit(string id)
        {
            var blogPost = this.dbContext.BlogPosts.FirstOrDefaultAsync(bp => bp.Id.Equals(id)).Result;

            if (blogPost == null)
            {
                return NotFound();
            }

            var model = this.mapper.Map<BlogPost, BlogPostBindingModel>(blogPost);

            ;

            return await Task.Run(() => this.View("Edit", model));
        }

        [HttpPost]
        [Route("admin/edit/{id}")]
        public async Task<IActionResult> Edit(BlogPostBindingModel model)
        {
            var blogPost = await this.dbContext.BlogPosts.FirstOrDefaultAsync(bp => bp.Id.Equals(model.Id));

            blogPost.Title = model.Title;
            blogPost.Category = model.Category;
            blogPost.Content = model.Content;
            blogPost.ImageUrl = model.ImageUrl;
            blogPost.Writer = model.Writer;
            blogPost.IsDraft = model.IsDraft;

            this.dbContext.BlogPosts.Update(blogPost);
            await this.dbContext.SaveChangesAsync();

            if (!blogPost.IsDraft)
            {
                return this.RedirectToAction("Published");
            }
            else
            {
                return this.RedirectToAction("Drafts");
            }
        }

        [HttpGet]
        [Route("admin/delete/{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var blogPost = await this.dbContext.BlogPosts.FirstOrDefaultAsync(bp => bp.Id.Equals(id));

            if (blogPost == null)
            {
                return NotFound();
            }

            var model = this.mapper.Map<BlogPost, BlogPostBindingModel>(blogPost);

            return await Task.Run(() => this.View("Delete", model));
        }

        [HttpPost]
        [Route("admin/delete/{id}")]
        public async Task<IActionResult> Delete(BlogPostBindingModel model)
        {
            var blogPost = await this.dbContext.BlogPosts.FirstOrDefaultAsync(bp => bp.Id.Equals(model.Id));

            this.dbContext.BlogPosts.Remove(blogPost);
            await this.dbContext.SaveChangesAsync();

            return this.RedirectToAction("All");
        }

        [HttpGet]
        [Route("admin/publish/{id}")]
        public async Task<IActionResult> Publish(string id)
        {
            var blogPost = await this.dbContext.BlogPosts.FirstOrDefaultAsync(bp => bp.Id.Equals(id));

            if (blogPost == null)
            {
                return NotFound();
            }

            var model = this.mapper.Map<BlogPost, BlogPostBindingModel>(blogPost);

            return await Task.Run(() => this.View("Publish", model));
        }

        [HttpPost]
        [Route("admin/publish/{id}")]
        public async Task<IActionResult> Publish(BlogPostBindingModel model)
        {
            var blogPost = await this.dbContext.BlogPosts.FirstOrDefaultAsync(bp => bp.Id.Equals(model.Id));

            blogPost.IsDraft = false;

            await this.dbContext.SaveChangesAsync();

            return this.RedirectToAction("All");
        }
    }
}