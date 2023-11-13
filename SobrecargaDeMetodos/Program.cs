Console.WriteLine("Assinatura de método - Sobrecarga");

Endereco email = new Endereco();

email.Enviar("teste@gmai.com");
email.Enviar("teste@gmail.com", "testando");

public class Endereco
{
    public void Enviar(string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Assunto padrào");
    }

    public void Enviar(string endereco, string assunto)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"{assunto}");
    }

    public void Enviar(string endereco, decimal valor)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Proposta Comercial");
        Console.WriteLine($"{valor}");
    }

    public void Enviar(decimal valor, string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Pagamento Fornecedor");
        Console.WriteLine($"{valor}");
    }
}