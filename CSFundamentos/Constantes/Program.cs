Console.WriteLine("Constantes");

// calculo para area e perimetro do circulo

double raio, perimetro, area;

const double PI = 3.14;

Console.WriteLine("Informe o raio do circulo");
raio = Convert.ToDouble(Console.ReadLine());

perimetro = 2 * PI * raio;

area = PI * Math.Pow(raio, 2);  

Console.WriteLine($"Perimetro = {perimetro}");
Console.WriteLine($"Area = {area}");

Console.ReadKey();
