
namespace aula05
{
    public class Praia
    {
        public string Nome;
        public string Localizacao;
        public int TemperaturaMedia;
        public bool TemQuiosque;

        public Praia(string nome, string localizacao, int temperaturaMedia, bool temQuiosque)
        {
            Nome = nome;
            Localizacao = localizacao;
            TemperaturaMedia = temperaturaMedia;
            TemQuiosque = temQuiosque;
        }

        public void ExibirPraia()
        {
            Console.WriteLine($"Praia: {Nome}");
            Console.WriteLine($"Localizacao: {Localizacao}");
            Console.WriteLine($"Temperatura Média: {TemperaturaMedia}ºC");
            if (TemQuiosque == true)
            {
                Console.WriteLine($"Tem Quisoque?: Sim");
            }
            else
            {
                Console.WriteLine($"Tem Quisoque?: Não");
            }
        }
    }
}