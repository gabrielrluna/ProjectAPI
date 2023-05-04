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

        [HttpGet ("")]
        public IActionResult Get() {
            var novo = new PersonModel(1, "");
            return Ok(novo); //200
            //201
            //400
            //500
        }
    }
}