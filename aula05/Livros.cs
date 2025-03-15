
namespace aula05
{
    public class Livro
    {
        public string Titulo;
        public string Autor;
        public string AnoPublicacao;


        public Livro(string titulo, string autor, string anoPublicacao)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
        }

        public void ExixbirDetalhes()
        {
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"===================");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"===================");
            Console.WriteLine($"Ano de Publicação: {AnoPublicacao}");
        }
    }
}