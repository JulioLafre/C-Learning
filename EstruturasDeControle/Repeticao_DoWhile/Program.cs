Console.WriteLine("## Comando Do While");


/* A Caracteristica do laco DoWhile é sempre executar a instrução pelo menos
uma vez, idependente de entrar no laco de repetição ou não. */

int i = 1;

do
{
    Console.WriteLine($"i = {i}");
    i++;
}
while ( i <= 10 );

Console.WriteLine("Fim do processamento");
Console.ReadKey();

/* Estrutura Do While Aninhadas */

int x = 0;
do
{
    int y = 0;
    do
    {
        Console.WriteLine($"{x},{y}");
        y++;
    }
    while (y < 5);
    x++;
    Console.WriteLine();
}
while ( x < 5 );
Console.WriteLine("Fim do processamento");

Console.ReadKey();