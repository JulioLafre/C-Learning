using System.Collections;

var lista = new ArrayList() { "Maria", 5, true, " ", null};

lista.Add(3.5);

lista.Insert(2, "Paulo");

foreach (var elemento in lista)
{
    Console.WriteLine(elemento);
}

Console.ReadKey();

var lista2 = new ArrayList() { "Maria", 5, true };

int[] teste1 = { 1, 2, 3 };
lista2.AddRange(teste1);

var teste2 = new ArrayList() { "Pedro", null, 312431.31231};

lista2.InsertRange(2, teste2);

foreach (var elementos in lista2)
{
    Console.WriteLine(elementos);
}

Console.ReadKey(true);