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
            biblioteca.Add(new BibliotecaModel(1, "A P�tria de Chuteiras","Marcos Alvito",2014, "Hist�ria", "Em prol da boa rela��o com o leitor, sejamos honestos - ainda n�o conseguimos descobrir se a rainha da Inglaterra cal�a mesmo chuteiras ou se bate uma bolinha em seu pal�cio de ver�o. Mas sabemos outras coisas sobre o futebol ingl�s. Por mais que o Brasil seja o pa�s do futebol, precisamos admitir que esse esporte nasceu do outro lado do Atl�ntico.", true));
            biblioteca.Add(new BibliotecaModel(2, "Dom Casmurro", "Machado de Assis", 1899, "Literatura", "� uma das grandes obras de Machado de Assis e confirma o olhar certeiro e cr�tico que o autor estendia sobre toda a sociedade brasileira. Tamb�m a tem�tica do ci�me, abordada com brilhantismo nesse livro, provoca pol�micas em torno do car�ter de uma das principais personagens femininas da literatura brasileira: Capitu.", true));
            biblioteca.Add(new BibliotecaModel(3, "Mem�rias P�stumas de Br�s Cubas", "Machado de Assis", 1881, "Literatura", "N�o tive filhos, n�o transmiti a nenhuma criatura o legado da nossa mis�ria. Com essas palavras, o narrador de Mem�rias P�stumas de Br�s Cubas resume a sua vida. O tom assumido na obra, bem como as t�cnicas empregadas na composi��o romanesca, s�o alguns dos fatores que justificam o lugar de Machado de Assis entre os maiores escritores do s�culo XIX. Neste romance repleto de digress�es filos�ficas, o escritor se vale da posi��o privilegiada de Br�s Cubas, que, como defunto autor, narra as suas desventuras e revela as contradi��es da sociedade brasileira do s�culo XIX, por meio de uma an�lise aprofundada de seus personagens.\r\n", false));
            biblioteca.Add(new BibliotecaModel(4, "O Grande Conflito", "Ellen G. White", 1858, "Religioso", "No grande conflito entre o bem e o mal, a impress�o que se tem � a de que o mal est� levando a melhor. As not�cias s�o desanimadoras - viol�ncia, fome, desemprego, doen�as, acidentes e outras calamidades est�o na ordem do dia. Os meios de comunica��o podem lhe dizer o que est� acontecendo. Mas este livro revela por qu�. E diz tamb�m o que voc� jamais ouvir� no notici�rio - o que ainda est� por acontecer. Anime-se. A guerra est� no fim e voc� ainda pode escolher de que lado estar� quando tudo terminar.", true));
            biblioteca.Add(new BibliotecaModel(5, "Como Fazer Amigos e Influenciar Pessoas", "Dale Carnegie", 1936, "Autoajuda", "Um dos maiores cl�ssicos de todos os tempos, Como fazer amigos e influenciar pessoas � considerado a B�blia dos relacionamentos interpessoais.", false ));



            return Ok(biblioteca); //200

        }

        [HttpDelete()]
        public IActionResult Delete([FromQuery] int id)
        {
            if (id == 0)
                return BadRequest("Opa! Voc� n�o pode usar este ID");
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
                return BadRequest("Opa! Voc� n�o pode usar este ID");
            }
            return Ok();
        }


        [HttpPatch("{id:int}")]
        public IActionResult Update2([FromRoute] int id, [FromBody] BibliotecaModel model)
        {
            if (id == 0)
            {
                return BadRequest("Opa! Voc� n�o pode usar este ID");
            }
            return Ok();
        }

    }
}