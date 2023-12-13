using Indexadores;

Times times = new Times();

//atribui valores = set
times[1] = "Palmeiras";
times[3] = "Vasco";
times[5] = "Santos";
times[7] = "Bahia";
times[-1] = "Goias";
times[100] = "Fluminense";

//Obtendo valores = get
string valor1 = times[1];
string valor2 = times[3];
string valor3 = times[5];
string valor4 = times[7];
string valor5 = times[-1];
string valor6 = times[100];


Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);
Console.WriteLine(valor4);
Console.WriteLine(valor5);
Console.WriteLine(valor6);

Console.ReadKey();