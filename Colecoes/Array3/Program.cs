int[] numeros = new int[10] {1,2,3,4,5,6,7,8,9,10};

string[] nomes = new string[3] { "Maria", "Joao", "Jonas" };

foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}

foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}


Console.ReadKey();