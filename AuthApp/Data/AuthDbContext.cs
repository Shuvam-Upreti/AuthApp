using AuthApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;

namespace Ecom.web.Data
{
    public class AuthDbContext : IdentityDbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {

        }
    }
}

