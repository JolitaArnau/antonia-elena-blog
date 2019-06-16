using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Antonia_Elena_Blog.Models
{
    public class User : IdentityUser<string>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}