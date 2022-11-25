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
    public class LikeActorsController : ControllerBase
    {
        private readonly CinemaDBContext _context;

        public LikeActorsController(CinemaDBContext context)
        {
            _context = context;
        }

        // GET: api/LikeActors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LikeActor>>> GetLikeActors()
        {
            return await _context.LikeActors.ToListAsync();
        }

        // GET: api/LikeActors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LikeActor>> GetLikeActor(int id)
        {
            var likeActor = await _context.LikeActors.FindAsync(id);

            if (likeActor == null)
            {
                return NotFound();
            }

            return likeActor;
        }

        // PUT: api/LikeActors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLikeActor(int id, LikeActor likeActor)
        {
            if (id != likeActor.Id)
            {
                return BadRequest();
            }

            _context.Entry(likeActor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LikeActorExists(id))
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

        // POST: api/LikeActors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LikeActor>> PostLikeActor(LikeActor likeActor)
        {
            _context.LikeActors.Add(likeActor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLikeActor", new { id = likeActor.Id }, likeActor);
        }

        // DELETE: api/LikeActors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLikeActor(int id)
        {
            var likeActor = await _context.LikeActors.FindAsync(id);
            if (likeActor == null)
            {
                return NotFound();
            }

            _context.LikeActors.Remove(likeActor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LikeActorExists(int id)
        {
            return _context.LikeActors.Any(e => e.Id == id);
        }
    }
}
