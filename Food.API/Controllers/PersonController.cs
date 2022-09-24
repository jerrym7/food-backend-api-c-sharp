using Food.API.Models;
using Food.API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Food.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //: => extends
    public class PersonController : ControllerBase
    {
        private IDatabase _personDatabase;
        public PersonController(IDatabase personDatabase) => _personDatabase = personDatabase;
        // ActionResults returns a status code and data
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Person>>> GetPeople() 
        {
            var people =  await _personDatabase.GetPeople();
            return Ok(people);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> GetPersonById(int id)
        {
            var person = await _personDatabase.GetPersonById(id);
            return person is null? NotFound() : Ok(person);
        }
    }
}
