
List<string> lista = new() 
{ 
    "uva", "maca", "pera", "abacaxi", "mexirica" 
};

//Usando Predicado como uma funcao
string fruta1 = lista.Find(Procurar);
Console.WriteLine(fruta1);

// Usando Expressao Lambda

string fruta2 = lista.Find(fruta => fruta.Contains("x"));
Console.WriteLine(fruta2);

string fruta3 = lista.FindLast(fruta => fruta.Contains("r"));
Console.WriteLine(fruta3);

int fruta4 = lista.FindIndex(fruta => fruta.Contains("c"));
Console.WriteLine(lista[fruta4]);

int fruta5 = lista.FindLastIndex(fruta => fruta.Contains("c"));
Console.WriteLine(lista[fruta5]);

var fruta6 = lista.FindAll(fruta => fruta.Contains("e"));
foreach (var item in fruta6)
{
    Console.WriteLine(item);
}


Console.ReadKey();


static bool Procurar(string item)
{
    return item.Contains("p");
}

