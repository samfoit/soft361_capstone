using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project361.Data;
using Project361.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project361.Controllers;

[Produces("application/json")]
[Route("api/[controller]")]
[ApiController]
public class PlayersController : Controller
{
    private readonly PlayerContext _context;

    public PlayersController(PlayerContext context)
    {
        _context = context;
    }

    // GET: api/players
    [HttpGet]
    public IEnumerable<Player> GetAllPlayers()
    {
        return _context.Players;
    }

    // GET: api/players/lastGame
    [HttpGet("lastGame")]
    public int GetLastPlayerGameId()
    {
        return _context.Players.OrderBy(p => p.Id).Last().GameId;
    }

    // GET: api/players/5
    [HttpGet("{gameId}")]
    public async Task<IActionResult> GetPlayer([FromRoute] int gameId)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var player = await _context.Players.Where(p => p.GameId == gameId).ToListAsync();

        if (player == null)
        {
            return NotFound();
        }

        return Ok(player);
    }

    // PUT: api/players/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutPlayer([FromRoute] int id, [FromBody] Player player)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        if (id != player.Id)
        {
            return BadRequest();
        }

        _context.Entry(player).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        } catch (DbUpdateConcurrencyException)
        {
            if (!PlayerExists(id))
            {
                return NotFound();
            } else
            {
                throw;
            }
        }

        return Ok(player);
    }

    // POST: api/players
    [HttpPost]
    public async Task<IActionResult> PostPlayer([FromBody] Player player)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        _context.Players.Add(player);
        await _context.SaveChangesAsync();

        return Ok(player);
    }

    // DELETE: api/player/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePlayer([FromRoute] int id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var player = await _context.Players.SingleOrDefaultAsync(m => m.Id == id);
        if (player == null)
        {
            return NotFound();
        }

        _context.Players.Remove(player);
        await _context.SaveChangesAsync();

        return Ok(player);
    }

    private bool PlayerExists(int id)
    {
        return _context.Players.Any(e => e.Id == id);
    }
}

