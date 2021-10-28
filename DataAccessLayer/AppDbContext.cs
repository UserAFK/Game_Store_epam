using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Genre> Genres { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
            if (Database.EnsureCreatedAsync().Result && Genres.CountAsync().Result <= 0)
                SetGenresTableAsync();
        }

        private async void SetGenresTableAsync()
        {
            await Genres.AddRangeAsync(
                new List<Genre>(){
                    new Genre(){Name = "Strategy"},
                    new Genre(){Name = "RPG"},
                    new Genre(){Name = "Sports"},
                    new Genre(){Name = "Races"},
                    new Genre(){Name = "Action"},
                    new Genre(){Name = "Adventure"},
                    new Genre(){Name = "Puzzle & Skill"},
                    new Genre(){Name = "Misc."}

            });
        }
    }
}
