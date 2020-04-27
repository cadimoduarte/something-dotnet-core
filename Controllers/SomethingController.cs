using Microsoft.AspNetCore.Mvc;
using SomethingWebApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TodoApi.Controllers
{
    [Route("something")]
    [ApiController]
    public class SomethingContorller : ControllerBase
    {
        private readonly SomethingContext _context;

        public SomethingContorller(SomethingContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Something> GetAll()
        {
            return _context.Somethings;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Something>> GetById(int id)
        {
            var item = await _context.Somethings.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        [HttpPost]
        public async Task<ActionResult<Something>> Post(Something something)
        {
            var entry = _context.Somethings.Add(something);
            var result = await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = something.Id }, something);
        }
    }
}