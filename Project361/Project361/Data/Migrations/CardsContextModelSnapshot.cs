﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project361.Data;

#nullable disable

namespace Project361.Data.Migrations
{
    [DbContext(typeof(CardsContext))]
    partial class CardsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.13");

            modelBuilder.Entity("Project361.Models.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Rank")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Suite")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Visible")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Rank = 1,
                            Suite = "Spades",
                            Visible = false
                        },
                        new
                        {
                            Id = 2,
                            Rank = 2,
                            Suite = "Spades",
                            Visible = false
                        },
                        new
                        {
                            Id = 3,
                            Rank = 3,
                            Suite = "Spades",
                            Visible = false
                        },
                        new
                        {
                            Id = 4,
                            Rank = 4,
                            Suite = "Spades",
                            Visible = false
                        },
                        new
                        {
                            Id = 5,
                            Rank = 5,
                            Suite = "Spades",
                            Visible = false
                        },
                        new
                        {
                            Id = 6,
                            Rank = 6,
                            Suite = "Spades",
                            Visible = false
                        },
                        new
                        {
                            Id = 7,
                            Rank = 7,
                            Suite = "Spades",
                            Visible = false
                        },
                        new
                        {
                            Id = 8,
                            Rank = 8,
                            Suite = "Spades",
                            Visible = false
                        },
                        new
                        {
                            Id = 9,
                            Rank = 9,
                            Suite = "Spades",
                            Visible = false
                        },
                        new
                        {
                            Id = 10,
                            Rank = 10,
                            Suite = "Spades",
                            Visible = false
                        },
                        new
                        {
                            Id = 11,
                            Rank = 11,
                            Suite = "Spades",
                            Visible = false
                        },
                        new
                        {
                            Id = 12,
                            Rank = 12,
                            Suite = "Spades",
                            Visible = false
                        },
                        new
                        {
                            Id = 13,
                            Rank = 13,
                            Suite = "Spades",
                            Visible = false
                        },
                        new
                        {
                            Id = 14,
                            Rank = 1,
                            Suite = "Hearts",
                            Visible = false
                        },
                        new
                        {
                            Id = 15,
                            Rank = 2,
                            Suite = "Hearts",
                            Visible = false
                        },
                        new
                        {
                            Id = 16,
                            Rank = 3,
                            Suite = "Hearts",
                            Visible = false
                        },
                        new
                        {
                            Id = 17,
                            Rank = 4,
                            Suite = "Hearts",
                            Visible = false
                        },
                        new
                        {
                            Id = 18,
                            Rank = 5,
                            Suite = "Hearts",
                            Visible = false
                        },
                        new
                        {
                            Id = 19,
                            Rank = 6,
                            Suite = "Hearts",
                            Visible = false
                        },
                        new
                        {
                            Id = 20,
                            Rank = 7,
                            Suite = "Hearts",
                            Visible = false
                        },
                        new
                        {
                            Id = 21,
                            Rank = 8,
                            Suite = "Hearts",
                            Visible = false
                        },
                        new
                        {
                            Id = 22,
                            Rank = 9,
                            Suite = "Hearts",
                            Visible = false
                        },
                        new
                        {
                            Id = 23,
                            Rank = 10,
                            Suite = "Hearts",
                            Visible = false
                        },
                        new
                        {
                            Id = 24,
                            Rank = 11,
                            Suite = "Hearts",
                            Visible = false
                        },
                        new
                        {
                            Id = 25,
                            Rank = 12,
                            Suite = "Hearts",
                            Visible = false
                        },
                        new
                        {
                            Id = 26,
                            Rank = 13,
                            Suite = "Hearts",
                            Visible = false
                        },
                        new
                        {
                            Id = 27,
                            Rank = 1,
                            Suite = "Clubs",
                            Visible = false
                        },
                        new
                        {
                            Id = 28,
                            Rank = 2,
                            Suite = "Clubs",
                            Visible = false
                        },
                        new
                        {
                            Id = 29,
                            Rank = 3,
                            Suite = "Clubs",
                            Visible = false
                        },
                        new
                        {
                            Id = 30,
                            Rank = 4,
                            Suite = "Clubs",
                            Visible = false
                        },
                        new
                        {
                            Id = 31,
                            Rank = 5,
                            Suite = "Clubs",
                            Visible = false
                        },
                        new
                        {
                            Id = 32,
                            Rank = 6,
                            Suite = "Clubs",
                            Visible = false
                        },
                        new
                        {
                            Id = 33,
                            Rank = 7,
                            Suite = "Clubs",
                            Visible = false
                        },
                        new
                        {
                            Id = 34,
                            Rank = 8,
                            Suite = "Clubs",
                            Visible = false
                        },
                        new
                        {
                            Id = 35,
                            Rank = 9,
                            Suite = "Clubs",
                            Visible = false
                        },
                        new
                        {
                            Id = 36,
                            Rank = 10,
                            Suite = "Clubs",
                            Visible = false
                        },
                        new
                        {
                            Id = 37,
                            Rank = 11,
                            Suite = "Clubs",
                            Visible = false
                        },
                        new
                        {
                            Id = 38,
                            Rank = 12,
                            Suite = "Clubs",
                            Visible = false
                        },
                        new
                        {
                            Id = 39,
                            Rank = 13,
                            Suite = "Clubs",
                            Visible = false
                        },
                        new
                        {
                            Id = 40,
                            Rank = 1,
                            Suite = "Diamonds",
                            Visible = false
                        },
                        new
                        {
                            Id = 41,
                            Rank = 2,
                            Suite = "Diamonds",
                            Visible = false
                        },
                        new
                        {
                            Id = 42,
                            Rank = 3,
                            Suite = "Diamonds",
                            Visible = false
                        },
                        new
                        {
                            Id = 43,
                            Rank = 4,
                            Suite = "Diamonds",
                            Visible = false
                        },
                        new
                        {
                            Id = 44,
                            Rank = 5,
                            Suite = "Diamonds",
                            Visible = false
                        },
                        new
                        {
                            Id = 45,
                            Rank = 6,
                            Suite = "Diamonds",
                            Visible = false
                        },
                        new
                        {
                            Id = 46,
                            Rank = 7,
                            Suite = "Diamonds",
                            Visible = false
                        },
                        new
                        {
                            Id = 47,
                            Rank = 8,
                            Suite = "Diamonds",
                            Visible = false
                        },
                        new
                        {
                            Id = 48,
                            Rank = 9,
                            Suite = "Diamonds",
                            Visible = false
                        },
                        new
                        {
                            Id = 49,
                            Rank = 10,
                            Suite = "Diamonds",
                            Visible = false
                        },
                        new
                        {
                            Id = 50,
                            Rank = 11,
                            Suite = "Diamonds",
                            Visible = false
                        },
                        new
                        {
                            Id = 51,
                            Rank = 12,
                            Suite = "Diamonds",
                            Visible = false
                        },
                        new
                        {
                            Id = 52,
                            Rank = 13,
                            Suite = "Diamonds",
                            Visible = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
