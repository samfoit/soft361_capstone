using System;
using Microsoft.EntityFrameworkCore;
using Project361.Models;

namespace Project361.Data;

public class SolitaireContext : DbContext
{
	public SolitaireContext(DbContextOptions<SolitaireContext> options) : base(options) { }

	public DbSet<Solitaire> SolitaireBoards { get; set; }
}

