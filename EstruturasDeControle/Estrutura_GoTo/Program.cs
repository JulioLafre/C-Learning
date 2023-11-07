Console.WriteLine("## Estrutura GoTo ##");

int i = 1;


repetir:
Console.WriteLine($"Valor de i {i}");
i++;
if (i < 10)
    goto repetir;

Console.WriteLine("Fim do processamento");

Console.ReadKey();
