// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string[] nomes = new string[5] { "Joao", "Maria", "Ana", "Jose", "Josevaldo" };

Console.WriteLine("\n\nExibindo array original");
ExibirArray(nomes);

Console.WriteLine("\n\nInvertendo array");
Array.Reverse(nomes);
ExibirArray(nomes);

Console.WriteLine("\n\nOrdenando array");
Array.Sort(nomes);
ExibirArray(nomes);

Console.WriteLine("\n\nLocalizando um item no array");
string nome = Console.ReadLine();

int indice = Array.BinarySearch(nomes, nome);

if(indice > -1)
{
    Console.WriteLine($"{nome} foi encontrado no indice {indice}");
}
else
{
    Console.WriteLine("Nome não encontrado");
}


Console.ReadKey();

static void ExibirArray(string[] nomes)
{
    foreach (string nome in nomes)
    {
        Console.WriteLine(nome);
    }
}