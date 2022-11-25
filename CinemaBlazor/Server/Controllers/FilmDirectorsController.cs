using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CinemaBlazor.Shared.Models;

namespace CinemaBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmDirectorsController : ControllerBase
    {
        private readonly CinemaDBContext _context;

        public FilmDirectorsController(CinemaDBContext context)
        {
            _context = context;
        }

        // GET: api/FilmDirectors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FilmDirector>>> GetFilmDirectors()
        {
            return await _context.FilmDirectors.ToListAsync();
        }

        // GET: api/FilmDirectors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FilmDirector>> GetFilmDirector(int id)
        {
            var filmDirector = await _context.FilmDirectors.FindAsync(id);

            if (filmDirector == null)
            {
                return NotFound();
            }

            return filmDirector;
        }

        // PUT: api/FilmDirectors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFilmDirector(int id, FilmDirector filmDirector)
        {
            if (id != filmDirector.Id)
            {
                return BadRequest();
            }

            _context.Entry(filmDirector).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FilmDirectorExists(id))
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

        // POST: api/FilmDirectors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FilmDirector>> PostFilmDirector(FilmDirector filmDirector)
        {
            _context.FilmDirectors.Add(filmDirector);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFilmDirector", new { id = filmDirector.Id }, filmDirector);
        }

        // DELETE: api/FilmDirectors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFilmDirector(int id)
        {
            var filmDirector = await _context.FilmDirectors.FindAsync(id);
            if (filmDirector == null)
            {
                return NotFound();
            }

            _context.FilmDirectors.Remove(filmDirector);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FilmDirectorExists(int id)
        {
            return _context.FilmDirectors.Any(e => e.Id == id);
        }
    }
}
