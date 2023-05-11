using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Project361.Models;

namespace Project361.Data;

public class CardsContext : DbContext
{
	public CardsContext(DbContextOptions<CardsContext> options) : base(options) { }

	public DbSet<Card> Cards { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Call the base version of this method (in DbContext) as well, else we sometimes get an error later on.
        base.OnModelCreating(modelBuilder);

        var cardsToSeed = new Card[52];

        for (int i = 1; i < 53; i++)
        {
            cardsToSeed[i - 1] = new()
            {
                Id = i,
                Rank = GetCardRank(i),
                Suite = GetCardSuite(i),
                Visible = false
            };
        }

        modelBuilder.Entity<Card>().HasData(cardsToSeed);
    }

    private int GetCardRank(int id)
    {
        int result = id % 13;

        if (result == 0)
        {
            return 13;
        }

        return result;
    }

    private string GetCardSuite(int id)
    {
        string result = "";

        if (id <= 13)
        {
            result = "Spades";
        } else if (id <= 26)
        {
            result = "Hearts";
        } else if (id <= 39)
        {
            result = "Clubs";
        } else
        {
            result = "Diamonds";
        }

        return result;
    }
}

