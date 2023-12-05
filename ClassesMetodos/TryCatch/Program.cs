try
{
    Console.WriteLine("Divisao de numeros inteiros");

    Console.WriteLine("x / y");

    Console.WriteLine("Informe o valor de x");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Informe o valor de y");
    int y = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(x / y);
}
catch (Exception ex)
{
    Console.WriteLine("Nao existe divisao por 0");
    Console.WriteLine($"ERRO: {ex.Message}");
    Console.WriteLine($"Detalhes {ex.StackTrace.ToString()}");
}
finally
{
    Console.WriteLine("Processamento Concluido");
}

Console.ReadKey(); 