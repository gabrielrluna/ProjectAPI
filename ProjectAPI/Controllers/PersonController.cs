using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using ProjectAPI.Controllers.Models;

namespace ProjectAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }
        //get //post //put //patch  //delete

        [HttpGet]
        public IActionResult Get()
        {
            List<PersonModel> person = new List<PersonModel>();
            person.Add(new PersonModel(1, "José"));
            person.Add(new PersonModel(2, "Maria"));
            person.Add(new PersonModel(3, "Luiz"));
            person.Add(new PersonModel(4, "Cláudia"));
            person.Add(new PersonModel(5, "Marcos"));

            return Ok(person); //200

        }

        [HttpDelete()]
        public IActionResult Delete([FromQuery] int id)
        {
            if (id == 0)
                return BadRequest("Opa! Você não pode usar este ID");
            // Rota para deletar
            return Ok(); //200

        }

        [HttpPost()]
        public IActionResult Create([FromBody] PersonModel model)
        {

            model.Id = 10;
            //return Created("Get/", model.Id); //201
            return StatusCode(StatusCodes.Status201Created, model.Id);
        }

        [HttpPut("{id:int}")]
        public IActionResult Update([FromRoute] int id, [FromBody] PersonModel model)
        {
            if (id == 0)
            {
                return BadRequest("Opa! Você não pode usar este ID");
            }
            return Ok();
        }


        [HttpPatch("{id:int}")]
        public IActionResult Update2([FromRoute] int id, [FromBody] PersonModel model)
        {
            if (id == 0)
            {
                return BadRequest("Opa! Você não pode usar este ID");
            }
            return Ok();
        }

    }
}