using Microsoft.AspNetCore.Identity;

namespace AuthIdentity.Models
{
    public class ApplicationRole:IdentityRole
    {
        public string? Description { get; set; }
    }
}
