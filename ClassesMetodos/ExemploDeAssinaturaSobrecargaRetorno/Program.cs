Console.WriteLine("Exemplo de Assinatura, Sobrecarga e Retorno");

Cadastro cadastro = new Cadastro();
Cliente cliente = cadastro.Registrar();
cadastro.ExibirDados(cliente);
Console.ReadKey();

cliente = cadastro.Registrar(cliente);
cadastro.ExibirDados("Renda Alterada", cliente);
Console.ReadKey();



public class Cliente
{
    public string? Nome;
    public int Idade;
    public decimal Renda;

    public Cliente (string? nome, int idade, decimal renda)
    {
        Nome = nome;
        Idade = idade;
        Renda = renda;
    }

    public Cliente()
    { }
}


public class Cadastro
{
    public Cliente Registrar()
    {
        Cliente cliente = new Cliente("Maria", 20 , 3000);
        return cliente;
    }
    public Cliente Registrar(Cliente cliente)
    {
        cliente.Renda = 3500;
        return cliente;
    }


    public void ExibirDados(Cliente cliente)
    {
        Console.Write($"{cliente.Nome}, {cliente.Idade}, {cliente.Renda.ToString("c")}");
    }

    public void ExibirDados(string texto, Cliente cliente)
    {
        Console.Write(texto);
        Console.Write($" {cliente.Nome}, {cliente.Idade}, {cliente.Renda.ToString("c")}");
    }

}