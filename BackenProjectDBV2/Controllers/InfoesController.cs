using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackenProjectDBV2.Models;

namespace BackenProjectDBV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfoesController : ControllerBase
    {
        private readonly BackEndProjectDBV2Context _context;

        public InfoesController(BackEndProjectDBV2Context context)
        {
            _context = context;
        }

        // GET: api/Infoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Info>>> GetInfos()
        {
            return await _context.Infos.ToListAsync();
        }

        // GET: api/Infoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Info>> GetInfo(int id)
        {
            var info = await _context.Infos.FindAsync(id);

            if (info == null)
            {
                return NotFound();
            }

            return info;
        }

        // PUT: api/Infoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInfo(int id, Info info)
        {
            if (id != info.Id)
            {
                return BadRequest();
            }

            _context.Entry(info).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InfoExists(id))
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

        // POST: api/Infoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Info>> PostInfo(Info info)
        {
            _context.Infos.Add(info);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInfo", new { id = info.Id }, info);
        }

        // DELETE: api/Infoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInfo(int id)
        {
            var info = await _context.Infos.FindAsync(id);
            if (info == null)
            {
                return NotFound();
            }

            _context.Infos.Remove(info);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InfoExists(int id)
        {
            return _context.Infos.Any(e => e.Id == id);
        }
    }
}
