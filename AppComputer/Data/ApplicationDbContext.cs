using System;
using System.Collections.Generic;
using System.Text;
using AppPCComponent.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PCComponents.Models;

namespace AppComputer.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PCComponents.Models.Component> Component { get; set; }
        public DbSet<PCComponents.Models.ComponentType> ComponentType { get; set; }
        public DbSet<PCComponents.Models.Computer> Computer { get; set; }
        public DbSet<PCComponents.Models.ComputerComponent> ComputerComponent { get; set; }
        public DbSet<PCComponents.Models.Order> Order { get; set; }
    }
}
