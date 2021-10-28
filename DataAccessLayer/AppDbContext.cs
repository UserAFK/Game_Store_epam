using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        { }
    }
}
