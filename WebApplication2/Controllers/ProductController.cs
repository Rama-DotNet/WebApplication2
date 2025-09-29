using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Model;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            // Placeholder response – no values assigned
            return Ok(new List<string>()); // You can replace string with Product later
        }

        // GET: api/product/{id}
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            // Placeholder response – no actual product lookup
            return Ok($"Requested product ID: {id}");
        }
    }
}

