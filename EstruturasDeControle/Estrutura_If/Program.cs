Console.WriteLine("Instrucao IF");

//Avaliando como char

Console.WriteLine("Cliente Especial (S/N)");
char resposta = Convert.ToChar(Console.ReadLine());

if(resposta == 'S')
{
    Console.WriteLine("Desconto de 10%");
}
Console.WriteLine("Fim do processamento");
Console.ReadKey();

//Avaliando como Bool

Console.WriteLine("Cliente Especial (True / False)");
bool resposta2 = Convert.ToBoolean(Console.ReadLine());

if (resposta2)
{
    Console.WriteLine("Desconto de 10%");
}
Console.WriteLine("Fim do processamento");
Console.ReadKey();

//Avaliando multiplas possibilidades

Console.WriteLine("Informe o valor de x\t");
int x  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y\t");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine("x é maior que y");
}
if (x < y)
{
    Console.WriteLine("x é menor que y ");
}
if (x == y)
{
    Console.WriteLine("x é igual a y");
}