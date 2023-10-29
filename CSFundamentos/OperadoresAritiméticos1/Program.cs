Console.WriteLine("Operadores Aritiméticos");

Console.WriteLine("\nInforme o valor de x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nInforme o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Raiz Quadrada de x = {Math.Sqrt(x)}");
Console.WriteLine($"Potencia de x elevado a y = {Math.Pow(x, y)}");
Console.WriteLine($"Valor minimo de x e y = {Math.Min(x, y)}");
Console.WriteLine($"Valor máximo de x e y = {Math.Max(x, y)}");
Console.WriteLine($"Coseno de x = {Math.Cos(x)}");
Console.WriteLine($"Seno de x = {Math.Sin(x)}");
Console.WriteLine($"Exponencial de x = {Math.Exp(x)}");


//Console.WriteLine($"Soma de x + y = {x + y}");
//Console.WriteLine($"Subtração de x - y = {x - y}");
//Console.WriteLine($"Multiplicação de x * y = {x * y}");
//double divisao = (double)x / y;
//Console.WriteLine($"Divisão de x / y = {divisao}");
//Console.WriteLine($"Resto da divisão de x / y = {x % y}");

Console.ReadKey();