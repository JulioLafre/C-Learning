string[] alunos = new string[5];
double[] notas = new double[5];


Console.WriteLine("Digite o nome e nota de 5 alunos");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite o nome:");
    alunos[i] = Console.ReadLine();

    Console.WriteLine("Digite a nota:");
    notas[i] = Convert.ToDouble(Console.ReadLine());
}


Console.WriteLine("\n\nNomes dos alunos: ");
foreach (string alunoNome in alunos)
{
    Console.WriteLine(alunoNome);
}

Console.WriteLine("\n\nNotas dos alunos");
foreach (double notaAluno in notas)
{
    Console.WriteLine(notaAluno);
}

Console.WriteLine("\n\nMedia Aritimetica das notas");
Console.WriteLine(CalculoMediaAritimetica(notas));

Console.ReadKey();

static double CalculoMediaAritimetica(double[] notas)
{

    double soma = 0;

    foreach(double notaAluno in notas)
    {
        soma += notaAluno;
    }

    double mediaAritimetica = soma / notas.Length;

    return mediaAritimetica;
}