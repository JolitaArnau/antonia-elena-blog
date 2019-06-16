using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Antonia_Elena_Blog.Models
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