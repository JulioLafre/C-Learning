Console.WriteLine("This");


Teste t1 = new Teste();

t1.Num1 = 10;
t1.Num2 = 20;
t1.Exibir();

Teste t2 = new Teste();
t2.Num2 = 30;
t2.Num1 = 50;
t2.Exibir();


NovoTeste t3 = new NovoTeste(888);

Console.ReadKey();


public class Teste
{
    public int Num1;
    public int Num2;

    public void PassarParametro(Teste t)
    {
        Console.WriteLine($"This = {this}");
        Console.WriteLine("Num1:" + t.Num1);
        Console.WriteLine("Num2:" + t.Num2);
    }

    public void Exibir()
    {
        PassarParametro(this);
    }

}


public class NovoTeste
{

    public NovoTeste(int num3, int num4)
    {
        Console.WriteLine($"Construtor com dois parametros {num3}, {num4}");
    }


    public NovoTeste(int num5): this(999,888)
    {
        Console.WriteLine("Construtor com um parametro" + num5);
    }

}


