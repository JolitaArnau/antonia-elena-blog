using Antonia_Elena_Blog.Areas.Admin.ViewModels;
using Antonia_Elena_Blog.Models;
using AutoMapper;

namespace Antonia_Elena_Blog.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            this.CreateMap<BlogPost, BlogPostBindingModel>();
        }
    }
}