Console.WriteLine("Struct");

Cliente cliente = new Cliente();

cliente.Nome = "Teste";
cliente.Idade = 24;

Console.WriteLine($"{cliente.Nome}, {cliente.Idade}");

Console.ReadKey();


public struct Cliente {

    public string? Nome { get; set; }
    public int Idade { get; set; }

    public Cliente(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

}