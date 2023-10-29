Console.WriteLine("Conversão de tipos ##\n");

int varInt = 100;               // int usa 4 bytes
double varDouble = varInt;      // double usa 8 bytes

Console.WriteLine(varDouble);

int numeroInt = 21312312;
long numeroLong = numeroInt;
float numeroFloat= numeroInt;
double numeroDouble = numeroInt;
decimal numeroDecimal = numeroInt;

Console.WriteLine(numeroLong);
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroDecimal);
Console.WriteLine(numeroInt);

Console.ReadKey();

// Conversäo que não é possível:
// double varDouble = 12.321;       8 bytes
// int varInt = varDouble;          4 bytes\


//como realizar:
double vDouble = 12.43;
int vInt = (int)varDouble;

Console.WriteLine(vInt);

int num1 = 10;
int num2 = 20;

float resultado = (float)num1 / num2;

Console.WriteLine(resultado);

Console.ReadKey();
