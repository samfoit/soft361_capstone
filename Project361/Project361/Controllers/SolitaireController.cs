using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project361.Data;
using Project361.Models;

namespace Project361.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SolitaireController : ControllerBase
{
    private readonly SolitaireContext _context;

    public SolitaireController(SolitaireContext context)
    {
        _context = context;
    }

    // GET: api/Solitaire/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Solitaire>> GetSoliatire(int id)
    {
        if (_context.SolitaireBoards == null)
        {
            return NotFound();
        }
        var solitaire = await _context.SolitaireBoards.FindAsync(id);

        if (solitaire == null)
        {
            return NotFound();
        }

        return solitaire;
    }

    // PUT: api/Solitaire/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutSoliatire(int id, Solitaire solitaire)
    {
        if (id != solitaire.Id)
        {
            return BadRequest();
        }

        _context.Entry(solitaire).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!SolitaireExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // POST: api/Solitaire
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Solitaire>> PostSoliatire(Solitaire soliatire)
    {
        if (_context.SolitaireBoards == null)
        {
            return Problem("Entity set 'SolitaireContext.SolitaireBoards'  is null.");
        }
        _context.SolitaireBoards.Add(soliatire);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetSoliatire", new { id = soliatire.Id }, soliatire);
    }

    private bool SolitaireExists(int id)
    {
        return (_context.SolitaireBoards?.Any(e => e.Id == id)).GetValueOrDefault();
    }
}

