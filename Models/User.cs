using Microsoft.AspNetCore.Identity;

namespace Your_Blog_Template.Models
{
    public class User : IdentityUser<string>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}