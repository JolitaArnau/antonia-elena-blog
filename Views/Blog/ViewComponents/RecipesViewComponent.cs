using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Antonia_Elena_Blog.Areas.Admin.ViewModels;
using Antonia_Elena_Blog.Data;
using Antonia_Elena_Blog.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Antonia_Elena_Blog.Views.Blog.ViewComponents
{
    public class RecipesViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public RecipesViewComponent(ApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var recipes = await this.dbContext.BlogPosts.Where(c => c.Category.Equals("Rezepte&Kochinspo"))
                .ToArrayAsync();

            var recipesViewModel = this.mapper.Map<BlogPost[], IEnumerable<BlogPostBindingModel>>(recipes)
                .OrderBy(d => d.CreatedOn);

            return View(recipesViewModel);
        }
    }
}