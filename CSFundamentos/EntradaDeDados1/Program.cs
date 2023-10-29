Console.WriteLine("\n## Entrada de Dados ##");
Console.WriteLine("\nInforme o seu nome");


string nome = Console.ReadLine();
Console.WriteLine($"O seu nome é {nome}");

Console.WriteLine("\nInforme a sua idade");
int idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A sua idade é {idade}");

Console.ReadKey();
