using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EQrent___Projekt.Models;

namespace EQrent___Projekt.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<EQrent___Projekt.Models.Item>? Item { get; set; }
        public DbSet<EQrent___Projekt.Models.ItemType>? ItemType { get; set; }
        public DbSet<EQrent___Projekt.Models.Rent>? Rent { get; set; }
    }
}