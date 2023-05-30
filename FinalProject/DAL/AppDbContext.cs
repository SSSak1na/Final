using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System;
using FinalProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FinalProject.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
       
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Setting> Settings { get; set; }

    }

  

}
