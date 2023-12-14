Random random = new Random();

int[] numerosSorteados = new int[10];


for (int i = 0; i < numerosSorteados.Length; i++)
{
    int numeroAleatorio = 0;
    do
    {
        numeroAleatorio = random.Next(1,61);
    }
    while (numerosSorteados.Contains(numeroAleatorio));
    numerosSorteados[i] = numeroAleatorio;
}

Array.Sort(numerosSorteados);
Console.WriteLine("Numeros Sorteados");
Console.WriteLine(string.Join(" ", numerosSorteados));

Console.ReadLine();
