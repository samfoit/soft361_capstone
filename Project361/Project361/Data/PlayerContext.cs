using System;
using Microsoft.EntityFrameworkCore;
using Project361.Models;

namespace Project361.Data
{
	public class PlayerContext : DbContext
	{
        public PlayerContext(DbContextOptions<PlayerContext> options) : base(options) { }

        public DbSet<Player> Players { get; set; }

        private string[] names = { "Sam", "Ethan", "Aden", "Pranav", "Chris", "Indigo" };

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Call the base version of this method (in DbContext) as well, else we sometimes get an error later on.
            base.OnModelCreating(modelBuilder);

            var playersToSeed = new Player[6];

            for (int i = 1; i < playersToSeed.Length + 1; i++)
            {
                playersToSeed[i - 1] = new()
                {
                    Id = i,
                    GameId = 1,
                    Name = names[i - 1],
                    Score = 0
                };
            }

            modelBuilder.Entity<Player>().HasData(playersToSeed);
        }
    }
}

