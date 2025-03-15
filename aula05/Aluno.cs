public class Aluno
{
    public string Nome;
    public int Matricula;
    public int Idade;


    public Aluno(string nome, int matricula, int idade)
    {
        Nome = nome;
        Matricula = matricula;
        Idade = idade;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Aluno: {Nome}, Matricula: {Matricula}, idade: {Idade}");
    }
}