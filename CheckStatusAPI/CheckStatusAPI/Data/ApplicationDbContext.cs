using CheckStatusAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CheckStatusAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;
    }
}
