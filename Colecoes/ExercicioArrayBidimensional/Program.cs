string[,] alunos = new string[2,5];



Console.WriteLine("\nDigite o nome de 10 alunos:\n");
for (int i = 0; i < alunos.GetLength(0); i++)
{

    for(int j = 0; j < alunos.GetLength(1); j++)
    {

        Console.WriteLine($"Digite o nome do aluno na posição {i}, {j}");
        alunos[i, j] = Console.ReadLine();
    }
}


Console.WriteLine("\n\nExibindo nome dos alunos salvos");
for (int i = 0; i < alunos.GetLength(0); i++)
{

    for (int j = 0; j < alunos.GetLength(1); j++)
    {

        Console.WriteLine($"Posição do Aluno: {i}, {j} " +
            $" - Nome do Aluno: {alunos[i, j]}");
    }
}

Console.ReadKey();