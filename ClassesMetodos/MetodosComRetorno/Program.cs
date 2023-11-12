Console.WriteLine("Metodos com Retorno");


Calculadora calc = new Calculadora();

int valor = calc.Somar(10, 20);
Console.WriteLine(valor);
Console.WriteLine(calc.Multiplicar(20,30));


Console.ReadKey();

public class Calculadora { 

    public int Somar(int n1, int n2)
    {
        return n1 + n2;
    }

    public int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }

    public int Dividir(int n1, int n2)
    {
        return n1 / n2;
    }

    public int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }

}