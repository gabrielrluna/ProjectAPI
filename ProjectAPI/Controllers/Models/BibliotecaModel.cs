using Microsoft.AspNetCore.Mvc.Formatters;

namespace ProjectAPI.Controllers.Models
{
    public class BibliotecaModel
    {
        public BibliotecaModel(int id,
                           string livro,
                           string autor,
                           int ano,
                           string genero,
                           string descricao,
                           bool disponibilidade)
        {
            Id = id; //Identificador
            Livro = livro; //Nome do Livro
            Autor = autor; //Nome do autor
            Ano = ano; //Ano em que o livro foi criado
            Genero = genero; //Gênero do livro
            Descricao = descricao; //Descrição do livro
            Disponibilidade = disponibilidade; //Declaração sobre a disponibilidade do livro na biblioteca
        }

        public int Id { get; set; }
        public string Livro { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }
        public string Genero { get; set; }
        public string Descricao { get; set; }
        public bool Disponibilidade { get; set; }

    }
}
