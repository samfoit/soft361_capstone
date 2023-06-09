﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project361.Data;

#nullable disable

namespace Project361.Data.Migrations
{
    [DbContext(typeof(SolitaireContext))]
    [Migration("20230510220840_SolitaireMigration")]
    partial class SolitaireMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.13");

            modelBuilder.Entity("Project361.Models.Solitaire", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CardRows")
                        .HasColumnType("TEXT");

                    b.Property<string>("DeckPile")
                        .HasColumnType("TEXT");

                    b.Property<string>("DrawPile")
                        .HasColumnType("TEXT");

                    b.Property<string>("SuitePiles")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("SolitaireBoards");
                });
#pragma warning restore 612, 618
        }
    }
}
