using Microsoft.AspNetCore.Identity;
using System;

namespace Infrastructure
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
