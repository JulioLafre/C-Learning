Console.WriteLine("## Laco de Repeticao For ##");

int numero;

Console.WriteLine("Informe um numero inteiro");
numero = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"Tabuada de {numero}");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{i} X {numero} = {i * numero}");
}

Console.ReadKey();

/* Multiplas expressoes em loop for */

Console.WriteLine("## Loop For ##");

for (int a1 = 0, a2 = 0; a1 + a2 <= 20; a1++, a2++)
{
    Console.WriteLine($"a1 = {a1}, a2 = {a2}");
}

/* Declarando For implicitamente */

int implicito = 0;

for(;implicito < 10;)
{
    Console.WriteLine($"implicito = {implicito}");
    implicito++;
}

/* Estrutura For Aninhada */

for(int eixoX =  0; eixoX < 5; eixoX++)
{
    for (int eixoY = 0; eixoY < 5; eixoY++)
    {
        Console.WriteLine($"{eixoX}, {eixoY}");
    }
}
Console.ReadKey();
