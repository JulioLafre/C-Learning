Console.WriteLine("Estrutura Switch/Case");

int compra = 600;
Console.WriteLine($"Valor da compra = {compra}");
Console.WriteLine("Informe o no. de parcelas que (1 a 3)");
int numParcelas = Convert.ToInt32(Console.ReadLine());


//Como utilizar o switch case

switch (numParcelas)
{
    case 1:
        Console.WriteLine($"\nPrestação no valor de {compra/numParcelas}");
        break;
    case 2:
        Console.WriteLine($"\nPrestação no valor de {compra / numParcelas}");
        break;
    case 3:
        Console.WriteLine($"\nPrestação no valor de {compra / numParcelas}");
        break;
    default:
        Console.WriteLine("\nInforme um número de parcelas válido");
        break;
}

Console.ReadKey();

// outro exemplo


Console.WriteLine("Informe um número inteiro");
int numInt = Convert.ToInt32(Console.ReadLine());

switch(numInt % 2)
{
    case 0:
        Console.WriteLine($"{numInt} é par");
        break;
    case 1:
        Console.WriteLine($"{numInt} é impar");
        break;

}