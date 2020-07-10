using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MeetCapstone.Models;
using Microsoft.AspNetCore.Identity;

namespace MeetCapstone.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder) 
        { 
            base.OnModelCreating(builder); 
            builder.Entity<IdentityRole>()
                .HasData(
                new IdentityRole
                { Name = "Admin",
                    NormalizedName = "CLIENT"
                }
                ); 
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Garage> Garages { get; set; }
        public DbSet<Meet> Meets { get; set; }
        public DbSet<Client> Clients { get; set; }
        
    }
}
