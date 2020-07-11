using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthApplication.Areas.Identity.Data;
using AuthApplication.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthApplication.Data
{
    public class AuthDBContext : IdentityDbContext<ApplicationUser, ApplicationRole , string>
    {
        public AuthDBContext() : base()
        {
                
        }
        public AuthDBContext(DbContextOptions<AuthDBContext> options)
            : base(options)
        {
        }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Product> products { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
