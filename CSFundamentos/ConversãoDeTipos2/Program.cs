Console.WriteLine("## Conversão de tipos ##\n");

int valorInt  = 0;
double valorDouble = 0;
decimal valorDecimal = 0;

string v1 = valorDecimal.ToString();
string v2 = valorDecimal.ToString();
string v3 = valorDecimal.ToString();

int numero1 = 10;
double numero2 = 5.34;
bool valorBoolean = true;

Console.WriteLine(Convert.ToString(numero2));
Console.WriteLine(Convert.ToDouble(numero1));
Console.WriteLine(Convert.ToString(valorBoolean));

//Atentar-se sempre aos tipos de conversão de estreitamento, pois ela pode gerar erros de OverFlow
//int varnumero = 10000;
//Console.WriteLine(Convert.ToByte(varnumero));

Console.ReadLine();
