Console.WriteLine("Construtor Estatico");
Pessoa p1 = new(19, "Maria");
Console.WriteLine($"{p1.Nome} - {p1.Idade}");


Pessoa p2 = new(33, "Joao");
Console.WriteLine($"{p2.Nome} - {p2.Idade}");


    public class Pessoa
{
    public static int IdadeMinima;
    public int Idade { get; set; }
    public string Nome { get; set; } = string.Empty;

    public Pessoa(int idade, string nome)
    {
        Idade = idade;
        Nome = nome;
    }

    public Pessoa()
    { }

    static Pessoa()
    {
        Console.WriteLine("Execuntado o construtor estatico");
        Console.WriteLine("Inicializando o campo IdadeMinima");
        IdadeMinima = 18;
    }

}

