Console.WriteLine("Instrução If-Else");

Console.WriteLine("Informe a nota do aluno");
int nota = Convert.ToInt32(Console.ReadLine());

//Utilizção da Estrutura If-Else

if(nota > 5)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
}
Console.WriteLine("Fim do processamento");
Console.ReadKey();

//If e else aninhados (não recomendavel)

Console.WriteLine("Informe o valor de x\t");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y\t");
int y = Convert.ToInt32(Console.ReadLine());

if(x > y)
{
    Console.WriteLine("x é maior que y");
}
else
{
    if( x < y)
    {
        Console.WriteLine("x é menor do que y");
    }
    else
    {
        Console.WriteLine("x é igual a y");
    }
}
