using System.Collections;

var lista = new ArrayList() { "Maria", "Ana", "Zlda", "Carlos", "Dina" };

Console.WriteLine("Valor original do Array\n");
foreach (var nome in lista)
{
    Console.Write($"{nome} ");
}

Console.WriteLine("\n\nOrdenando itens\n");
lista.Sort();
foreach (var nome in lista)
{
    Console.Write($"{nome} ");
}

Console.WriteLine($"\n\nnumero de elemento no array {lista.Count}");

lista.Clear();

Console.WriteLine($"\nnumeros de elementos no array depois do clear {lista.Count}");

Console.ReadKey();
