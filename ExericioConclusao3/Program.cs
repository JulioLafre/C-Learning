    //3 - Escreva um programa em C# que solicite ao usuário que informe o valor das notas, do tipo float , para 10
    //alunos divididos em 2 grupos de 5 alunos cada. Armazene as informações em um array bidimensional e a
    //seguir exiba no console a média aritmética de cada grupo de alunos (grupo1 e grupo2).


    float[,] notasAlunos = new float[2,5];


    float MediaGrupo1 = 0.0f;
    float MediaGrupo2 = 0.0f;

    for (int i = 0; i < notasAlunos.GetLength(0) ; i++)
    {
        for(int j = 0; j < notasAlunos.GetLength(1) ; j++)
        {
            Console.WriteLine($"Digite a nota do {i + 1}º grupo do {j + 1}º aluno");
            notasAlunos[i,j] = Convert.ToSingle(Console.ReadLine());
        }
    }


    for(int l = 0; l < notasAlunos.GetLength(0) ; l++)
    {
        MediaGrupo1 += notasAlunos[0,l];
    }

    for (int m = 0; m < notasAlunos.GetLength(1); m++)
    {
        MediaGrupo2 += notasAlunos[1,m];
    }

Console.WriteLine($"Media do 1º grupo é {MediaGrupo1 / notasAlunos.GetLength(0)} ");
Console.WriteLine($"Media do 2º grupo é {MediaGrupo2 / notasAlunos.GetLength(1)} ");

Console.ReadKey();