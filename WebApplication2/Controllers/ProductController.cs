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
            
            return Ok(new List<string>());
        }
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok($"Requested product ID: {id}");
        }
    }
}
    
