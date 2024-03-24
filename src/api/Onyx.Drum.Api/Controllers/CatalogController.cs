using Microsoft.AspNetCore.Mvc;
using Onyx.Drum.Domain.Catalog;

namespace Onyx.Drum.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetItems()
        {
            var items = new[]
            {
                new Item("Item 1", "Description 1", "Brand 1", 100.00m),
                new Item("Item 2", "Description 2", "Brand 2", 200.00m),
                new Item("Item 3", "Description 3", "Brand 3", 300.00m),
                new Item("Item 4", "Description 4", "Brand 4", 400.00m)

            };
            return Ok(items);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetItem(int id)
        {
            var item = new Item("Item 1", "Description 1", "Brand 1", 100.00m)
            {
                Id = id
            };

            return Ok(item);
        }

        [HttpPost]
        public IActionResult CreateItem(Item item)
        {
            return CreatedAtAction(nameof(GetItem), new { id = 42 }, item);
        }

        [HttpPost("{id:int}/ratings")]
        public IActionResult AddRating(int id, Rating rating)
        {
            return Ok();
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateItem(int id, Item item)
        {
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteItem(int id)
        {
            return NoContent();
        }
    }
}