public class Voo
{
    public string NumeroVoo;
    public string Companhia;
    public string Origem;
    public string Destino;
    public DateTime HoraSaida;


    public Voo(string numeroVoo, string companhia, string origem, string destino, DateTime horaSaida)
    {
        NumeroVoo = numeroVoo;
        Companhia = companhia;
        Origem = origem;
        Destino = destino;
        HoraSaida = horaSaida;
    }


    public void ExibirDetalhes()
    {
        Console.WriteLine($"Voo: {NumeroVoo} | Companhia: {Companhia} | {Origem} → {Destino} às {HoraSaida}");
    }
}