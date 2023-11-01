Console.WriteLine("Estrutura If-Else-If");

Console.WriteLine("Informe a nota do aluno\t");
double nota = Convert.ToDouble(Console.ReadLine());

if (nota < 5)
{
    Console.WriteLine("Aluno reprovado");
}
else if (nota >= 5 && nota < 6)
{
    Console.WriteLine("Aluno de recuperação");
}
else if (nota >= 6 && nota <= 9)
{
    Console.WriteLine("Aluno aprovado");
}
else
{
    Console.WriteLine("Aluno aprovado com distinção");
}

Console.ReadKey();
