using AutoMapper;
using Your_Blog_Template.Areas.Admin.ViewModels;
using Your_Blog_Template.Models;

namespace Your_Blog_Template.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            this.CreateMap<BlogPost, BlogPostBindingModel>();
        }
    }
}