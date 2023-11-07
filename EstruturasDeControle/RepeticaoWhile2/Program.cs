Console.WriteLine("## Instrucao While ##");

while (true)
{
    Console.WriteLine("\n Informe um número inteiro: (Para sair digite 999)");
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero == 999)
    {
        break;
    }

    if (numero % 2 == 0)
    {
        Console.WriteLine($"O numero {numero} é par");
    }
    else
    {
        Console.WriteLine($"O numero {numero} é impar");
    }
}

Console.WriteLine("Fim do processamento");
Console.ReadKey();


/* Estrutura While Aninhadas */

int x = 0;

while (x < 5)
{
    int y = 0;
    while (y < 5)
    {
        Console.WriteLine($"{x},{y}");
        y++;
    }
    x++;
    Console.WriteLine();
}

Console.WriteLine("Fim do processamento");
Console.ReadKey();