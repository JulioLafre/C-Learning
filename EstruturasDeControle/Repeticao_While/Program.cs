Console.WriteLine("## Instrucao While ##");

int contador = 1;

while (contador < 10)
{
    Console.WriteLine($"Valor de i = {contador}");
    contador++;
}
Console.WriteLine("Fim do processamento..");

Console.ReadKey();

/* Imprimir a tabuada de um numero maior que zero */
Console.WriteLine("Digite um número");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    int i = 1;
    while (i <= 10)
    {
        Console.WriteLine($"{numero} X {i} = {numero * i}");
        i++;
    }
    
}
else
{
    Console.WriteLine("O numero precisa ser maior do que zero.");
}
Console.ReadKey();
