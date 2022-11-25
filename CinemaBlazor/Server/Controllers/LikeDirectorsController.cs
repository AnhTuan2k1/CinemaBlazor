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
    public class LikeDirectorsController : ControllerBase
    {
        private readonly CinemaDBContext _context;

        public LikeDirectorsController(CinemaDBContext context)
        {
            _context = context;
        }

        // GET: api/LikeDirectors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LikeDirector>>> GetLikeDirectors()
        {
            return await _context.LikeDirectors.ToListAsync();
        }

        // GET: api/LikeDirectors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LikeDirector>> GetLikeDirector(int id)
        {
            var likeDirector = await _context.LikeDirectors.FindAsync(id);

            if (likeDirector == null)
            {
                return NotFound();
            }

            return likeDirector;
        }

        // PUT: api/LikeDirectors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLikeDirector(int id, LikeDirector likeDirector)
        {
            if (id != likeDirector.Id)
            {
                return BadRequest();
            }

            _context.Entry(likeDirector).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LikeDirectorExists(id))
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

        // POST: api/LikeDirectors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LikeDirector>> PostLikeDirector(LikeDirector likeDirector)
        {
            _context.LikeDirectors.Add(likeDirector);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLikeDirector", new { id = likeDirector.Id }, likeDirector);
        }

        // DELETE: api/LikeDirectors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLikeDirector(int id)
        {
            var likeDirector = await _context.LikeDirectors.FindAsync(id);
            if (likeDirector == null)
            {
                return NotFound();
            }

            _context.LikeDirectors.Remove(likeDirector);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LikeDirectorExists(int id)
        {
            return _context.LikeDirectors.Any(e => e.Id == id);
        }
    }
}
