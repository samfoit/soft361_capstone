using System;
namespace Project361.Models;

public class Solitaire
{
	public int Id { get; set; }

	public string? DeckPile { get; set; }

	public string? DrawPile { get; set; }

	public string? CardRows { get; set; }

	public string? SuitePiles { get; set; }
}

