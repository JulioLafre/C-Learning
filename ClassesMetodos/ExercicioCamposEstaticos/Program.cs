ContaCorrente cliente1 = new ContaCorrente();
cliente1.Conta = 100;
cliente1.Nome = "Julio";
//cliente1.Juros = 3.5f;

ContaCorrente cliente2 = new ContaCorrente();
cliente2.Conta = 101;
cliente2.Nome = "Teste";
//cliente2.Juros = 4.43f;

ContaCorrente.Juros = 3.0f;

Console.WriteLine($"cliente: {cliente1.Nome} - Juros Anual: {cliente1.JurosAnual()}");
Console.WriteLine($"cliente: {cliente2.Nome} - Juros Anual: {cliente2.JurosAnual()}");


Console.ReadKey();

public class ContaCorrente
{
    public int Conta;
    public string? Nome;
    public static float Juros;

    public float JurosAnual()
    {
        return Juros * 12;
    }
}