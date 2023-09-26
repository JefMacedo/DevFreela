using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.Application.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/users")]
    public class UsersController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // api/users/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        // POST api/users
        [HttpPost]
        public IActionResult Post([FromBody] CreateUserInputModel createUserModel)
        {
            return CreatedAtAction(nameof(GetById), new { id = 1 }, createUserModel);
        }

        // PUT api/users/1/login
        [HttpPut("{id}/login")]
        public IActionResult Login(int id, [FromBody] LoginInputModel login)
        {
            return NoContent();
        }
    }
}

