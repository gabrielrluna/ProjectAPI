using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using ProjectAPI.Controllers.Models;

namespace ProjectAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BibliotecaController : ControllerBase
    {

        private readonly ILogger<BibliotecaController> _logger;

        public BibliotecaController(ILogger<BibliotecaController> logger)
        {
            _logger = logger;
        }
        //get //post //put //patch  //delete

        [HttpGet]
        public IActionResult Get()
        {
            List<BibliotecaModel> biblioteca = new List<BibliotecaModel>();
            biblioteca.Add(new BibliotecaModel(1, "A Pátria de Chuteiras","Marcos Alvito",2014, "História", "Em prol da boa relação com o leitor, sejamos honestos - ainda não conseguimos descobrir se a rainha da Inglaterra calça mesmo chuteiras ou se bate uma bolinha em seu palácio de verão. Mas sabemos outras coisas sobre o futebol inglês. Por mais que o Brasil seja o país do futebol, precisamos admitir que esse esporte nasceu do outro lado do Atlântico.", true));
            biblioteca.Add(new BibliotecaModel(2, "Dom Casmurro", "Machado de Assis", 1899, "Literatura", "é uma das grandes obras de Machado de Assis e confirma o olhar certeiro e crítico que o autor estendia sobre toda a sociedade brasileira. Também a temática do ciúme, abordada com brilhantismo nesse livro, provoca polêmicas em torno do caráter de uma das principais personagens femininas da literatura brasileira: Capitu.", true));
            biblioteca.Add(new BibliotecaModel(3, "Memórias Póstumas de Brás Cubas", "Machado de Assis", 1881, "Literatura", "Não tive filhos, não transmiti a nenhuma criatura o legado da nossa miséria. Com essas palavras, o narrador de Memórias Póstumas de Brás Cubas resume a sua vida. O tom assumido na obra, bem como as técnicas empregadas na composição romanesca, são alguns dos fatores que justificam o lugar de Machado de Assis entre os maiores escritores do século XIX. Neste romance repleto de digressões filosóficas, o escritor se vale da posição privilegiada de Brás Cubas, que, como defunto autor, narra as suas desventuras e revela as contradições da sociedade brasileira do século XIX, por meio de uma análise aprofundada de seus personagens.\r\n", false));
            biblioteca.Add(new BibliotecaModel(4, "O Grande Conflito", "Ellen G. White", 1858, "Religioso", "No grande conflito entre o bem e o mal, a impressão que se tem é a de que o mal está levando a melhor. As notícias são desanimadoras - violência, fome, desemprego, doenças, acidentes e outras calamidades estão na ordem do dia. Os meios de comunicação podem lhe dizer o que está acontecendo. Mas este livro revela por quê. E diz também o que você jamais ouvirá no noticiário - o que ainda está por acontecer. Anime-se. A guerra está no fim e você ainda pode escolher de que lado estará quando tudo terminar.", true));
            biblioteca.Add(new BibliotecaModel(5, "Como Fazer Amigos e Influenciar Pessoas", "Dale Carnegie", 1936, "Autoajuda", "Um dos maiores clássicos de todos os tempos, Como fazer amigos e influenciar pessoas é considerado a Bíblia dos relacionamentos interpessoais.", false ));



            return Ok(biblioteca); //200

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
        public IActionResult Create([FromBody] BibliotecaModel model)
        {

            //model.Id = 10;
            //return Created("Get/", model.Id); //201
            return StatusCode(StatusCodes.Status201Created, model.Id);
        }

        [HttpPut("{id:int}")]
        public IActionResult Update([FromRoute] int id, [FromBody] BibliotecaModel model)
        {
            if (id == 0)
            {
                return BadRequest("Opa! Você não pode usar este ID");
            }
            return Ok();
        }


        [HttpPatch("{id:int}")]
        public IActionResult Update2([FromRoute] int id, [FromBody] BibliotecaModel model)
        {
            if (id == 0)
            {
                return BadRequest("Opa! Você não pode usar este ID");
            }
            return Ok();
        }

    }
}