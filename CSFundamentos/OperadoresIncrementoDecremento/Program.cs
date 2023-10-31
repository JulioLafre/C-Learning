Console.WriteLine("Operadores de Incremento e Decremento");

//pós incremento -> primeiro avalia depois incrementa
int x = 0;
Console.WriteLine($"x = {x}");
int resultado1 = x++ + 10;
Console.WriteLine($"pós incremento -->  {resultado1}");
Console.WriteLine($"valor de x -->  {x}");

//pré incremento -> primeiro incrementa depois avalia
int y = 0;
Console.WriteLine($"y = {y}");
int resultado2 = ++y + 10;
Console.WriteLine($"pré incremento -->  {resultado2}");
Console.WriteLine($"valor de y -->  {y}");

//pós drecemento -> primeiro avalia depois decrementa
int z = 0;
Console.WriteLine($"x = {z}");
int resultado3 = z-- + 10;
Console.WriteLine($"pós incremento -->  {resultado3}");
Console.WriteLine($"valor de x -->  {z}");

//pré drecremento-> primeiro incrementa depois decrementa
int a = 0;
Console.WriteLine($"y = {a}");
int resultado4 = --a + 10;
Console.WriteLine($"pré incremento -->  {resultado4}");
Console.WriteLine($"valor de y -->  {a}");


Console.ReadKey();


