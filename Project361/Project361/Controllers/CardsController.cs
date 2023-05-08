using System;
using Microsoft.AspNetCore.Mvc;
using Project361.Data;
using Project361.Models;

namespace Project361.Controllers;

[ApiController]
[Produces("application/json")]
[Route("api/[controller]")]
public class CardsController : Controller
{
	private readonly CardsContext _context;

	public CardsController(CardsContext context)
	{
		_context = context;
	}

	// GET: api/cards or api/card?
	[HttpGet]
	public IEnumerable<Card> GetCards()
	{
		return _context.Cards;
	}

}

