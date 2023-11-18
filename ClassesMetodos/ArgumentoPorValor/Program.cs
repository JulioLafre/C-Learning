Console.WriteLine("Passagem de argumento por valor");

int x = 20;

Console.WriteLine($"Valor atual de x:{x}");

Calculo calculo = new Calculo();

calculo.Dobrar( x );

Console.WriteLine($"Valor de x: {x}");

Console.ReadKey();

public class Calculo
{
    public void Dobrar(int y)
    {
        y *= 2;
        Console.WriteLine($"Valor do parametro y = {y}");
    }
}
