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
    }
}