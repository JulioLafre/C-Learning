Console.WriteLine("Exercicio - Propriedades");

Produto p1 = new Produto();
p1.Nome = "Chaveiro";
p1.Preco = 4.50;
p1.EstoqueMinimo = 10;

p1.Exibir();

Console.ReadKey();


Console.ReadKey();
public class Produto
{
    private string? nome;
    public string? Nome
    {
        get { return nome.ToUpper(); }
        set { nome = value; }
    }

    private double preco;
    public double Preco 
    {
        get { return preco; }
        set {
            if (value < 5.0)
                preco = 5.0;
            else
                preco = value;
            } 
    }

    private double desconto = 0.05;
    public double Desconto
    {
        get { return desconto; }
    }

    public double PrecoFinal 
    { 
        get { return Preco - (Preco * Desconto); }
    }

    private int minimo;
    public int EstoqueMinimo 
    { 
        set { minimo = value; } 
    }

    public void Exibir()
    {
        Console.WriteLine($"{Nome} \n{Preco.ToString("c")} \n{Desconto}% " +
            $"\n{PrecoFinal.ToString("c")} \n{minimo}");
    }

}