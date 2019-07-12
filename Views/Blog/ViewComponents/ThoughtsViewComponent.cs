using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Your_Blog_Template.Areas.Admin.ViewModels;
using Your_Blog_Template.Data;
using Your_Blog_Template.Models;

namespace Your_Blog_Template.Views.Blog.ViewComponents
{
    public class ThoughtsViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public ThoughtsViewComponent(ApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var recipes = await this.dbContext.BlogPosts.Where(c => c.Category.Equals("Thoughts"))
                .ToArrayAsync();

            var recipesViewModel = this.mapper.Map<BlogPost[], IEnumerable<BlogPostBindingModel>>(recipes)
                .OrderBy(d => d.CreatedOn);

            return View(recipesViewModel);
        }
    }
}