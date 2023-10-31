Console.WriteLine("Operadores Relacionais");

int x = 10;
int y = 20;

Console.WriteLine($"Valor de x = {x}");
Console.WriteLine($"Valor de y = {y}");

Console.WriteLine(x == y);
bool resultado = x == y;
Console.WriteLine(resultado);

Console.WriteLine(x > y);
Console.WriteLine(x < y);
Console.WriteLine(x >= y);
Console.WriteLine(x <= y);
Console.WriteLine(x != y);

// Operadores com string 

string a = "Curso";
string b = "curso";

Console.WriteLine(a == b);
Console.WriteLine(a.Equals(b));

Console.ReadKey();