using System;
namespace Project361.Models;

public class Player
{
	public int Id { get; set; }
	public int GameId { get; set; }
	public string? Name { get; set; }
	public int Score { get; set; }
}

