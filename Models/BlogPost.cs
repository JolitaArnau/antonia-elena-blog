using System;

namespace Your_Blog_Template.Models
{
    public class BlogPost
    {
        public BlogPost()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        
        public string Id { get; set; }

        public string Category { get; set; }
        
        public string Title { get; set; }

        public string Writer { get; set; }
        
        public DateTime CreatedOn { get; set; }

        public string Content { get; set; }

        public string ImageUrl { get; set; }

        public bool IsDraft { get; set; }
    }
}