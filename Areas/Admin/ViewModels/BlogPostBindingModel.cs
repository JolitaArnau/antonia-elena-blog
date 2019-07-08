using System;

namespace Your_Blog_Template.Areas.Admin.ViewModels
{
    public class BlogPostBindingModel
    {
        public string Id { get; set; }
        
        public string Category { get; set; }
        
        public string Title { get; set; }
        
        public string Writer { get; set; }
        
        public DateTime CreatedOn = DateTime.Today.Date;

        public string Content { get; set; }

        public string ImageUrl { get; set; }

        public bool IsDraft { get; set; }
    }
}