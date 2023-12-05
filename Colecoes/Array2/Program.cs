int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

for(int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Indice {i}, numeros {numeros[i]}");
}


string[] nomes = new string[5] { "julio", "maria", "joao", "ana", "jose" };



int y = 0;
while(y < nomes.Length)
{
    Console.WriteLine($"Indice {y}, Nome {nomes[y]}");
    y++;
}

Console.ReadKey();