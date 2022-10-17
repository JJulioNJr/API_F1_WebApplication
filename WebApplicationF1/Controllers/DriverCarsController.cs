using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationF1.Data;
using WebApplicationF1.Models;

namespace WebApplicationF1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverCarsController : ControllerBase
    {
        private readonly WebApplicationF1Context _context;

        public DriverCarsController(WebApplicationF1Context context)
        {
            _context = context;
        }

        // GET: api/DriverCars
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DriverCar>>> GetDriverCar()
        {
            return await _context.DriverCar.ToListAsync();
        }

        // GET: api/DriverCars/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DriverCar>> GetDriverCar(int id)
        {
            var driverCar = await _context.DriverCar.FindAsync(id);

            if (driverCar == null)
            {
                return NotFound();
            }

            return driverCar;
        }

        // PUT: api/DriverCars/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDriverCar(int id, DriverCar driverCar)
        {
            if (id != driverCar.Id)
            {
                return BadRequest();
            }

            _context.Entry(driverCar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DriverCarExists(id))
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

        // POST: api/DriverCars
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DriverCar>> PostDriverCar(DriverCar driverCar)
        {
            _context.DriverCar.Add(driverCar);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDriverCar", new { id = driverCar.Id }, driverCar);
        }

        // DELETE: api/DriverCars/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDriverCar(int id)
        {
            var driverCar = await _context.DriverCar.FindAsync(id);
            if (driverCar == null)
            {
                return NotFound();
            }

            _context.DriverCar.Remove(driverCar);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DriverCarExists(int id)
        {
            return _context.DriverCar.Any(e => e.Id == id);
        }
    }
}
