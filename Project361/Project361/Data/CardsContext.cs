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
        base.OnModelCreating(modelBuilder);

        var cardsToSeed = new Card[52];

        for (int i = 1; i < 53; i++)
        {
            cardsToSeed[i - 1] = new()
            {
                Id = i,
                Rank = CardHelper.GetCardRank(i), 
                Suite = CardHelper.GetCardSuite(i),
                Visible = false
            };
        }

        modelBuilder.Entity<Card>().HasData(cardsToSeed);
    }
}
