﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HomeMeter.Data;
using HomeMeter.Models;

namespace HomeMeter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeterController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public MeterController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Meter
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Meter>>> GetMeter()
        {
            return await _context.Meter.ToListAsync();
        }

        // GET: api/Meter/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Meter>> GetMeter(int id)
        {
            var meter = await _context.Meter.FindAsync(id);

            if (meter == null)
            {
                return NotFound();
            }

            return meter;
        }

        // PUT: api/Meter/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMeter(int id, Meter meter)
        {
            if (id != meter.Id)
            {
                return BadRequest();
            }

            _context.Entry(meter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MeterExists(id))
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

        // POST: api/Meter
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Meter>> PostMeter(Meter meter)
        {
            _context.Meter.Add(meter);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMeter", new { id = meter.Id }, meter);
        }

        // DELETE: api/Meter/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Meter>> DeleteMeter(int id)
        {
            var meter = await _context.Meter.FindAsync(id);
            if (meter == null)
            {
                return NotFound();
            }

            _context.Meter.Remove(meter);
            await _context.SaveChangesAsync();

            return meter;
        }

        private bool MeterExists(int id)
        {
            return _context.Meter.Any(e => e.Id == id);
        }
    }
}
