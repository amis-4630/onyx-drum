using Microsoft.AspNetCore.Mvc;
using Onyx.Drum.Domain.Catalog;
using Onyx.Drum.Data; //use the name data project of your data project

namespace Onyx.Drum.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CatalogController : ControllerBase
    {

        private readonly StoreContext _context;

        public CatalogController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetItems()
        {
            return Ok(_context.Items);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetItem(int id)
        {
            var item = _context.Items.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        public IActionResult CreateItem(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            return Created($"api/catalog/{item.Id}", item);
        }

        [HttpPost("{id:int}/ratings")]
        public IActionResult AddRating(int id, Rating rating)
        {
            var item = _context.Items.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            item.AddRating(rating);
            _context.SaveChanges();

            return Ok(item);
        }

        using Microsoft.AspNetCore.Mvc;

        [HttpPut("{id:int}")]
    public IActionResult UpdateItem(int id, Item item)
    {
        if (id != item.Id)
        {
            return BadRequest();
        }

        if (_context.Items.Find(id) == null)
        {
            return NotFound();
        }

        _context.Items.Update(item);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteItem(int id)
    {
        return NoContent();
    }
}
}
