Console.WriteLine("## Break e Continue");

for (; ; )
{
    Console.WriteLine("Tecle algo (\"X\" Para sair)");
    string opcao = Console.ReadLine();

    Console.WriteLine(opcao.ToUpper());

    if (opcao == "X" || opcao == "x")
    {
        Console.WriteLine("Tchau...");
        break;
    }
}

/* Instrucao Continue interrompe uma iteracao em um looping */

for (int i = 0; i < 10; i++)
{
    if (i == 4)
    {
        continue;
    }
    Console.WriteLine($"{i}");
}

Console.ReadKey();


/* Aplicando Continue com While */

int n = 1;
while (n <= 10)
{
    if (n == 5)
    {
        n++;
        continue;
    }
    Console.WriteLine(n);
    n++;
}

Console.ReadKey();


/* Utilizando Break e Continue no mesmo laco */

for  (int j = 0;j < 10; j++)
{
    if(j == 5)
    {
        continue;
    }
    
    if(j == 8)
    {
        break;
    }
    Console.WriteLine(j);
}

Console.ReadKey();