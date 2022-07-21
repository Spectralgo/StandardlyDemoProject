using Microsoft.AspNetCore.Identity;
using System;

namespace StandardlyDemoProject.Api.Models.Users
{
    public class ApplicationUserRole : IdentityUserRole<Guid>
    {
        public virtual ApplicationUser User { get; set; }
        public virtual ApplicationRole Role { get; set; }
    }
}
