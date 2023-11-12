Console.WriteLine("Classes como parametros");


Aluno aluno = new Aluno();
aluno.CriarAluno();

public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;

    public void CriarAluno()
    {

        Aluno aluno = new Aluno();

        Console.WriteLine("Digite o seu nome:");
        aluno.Nome = Console.ReadLine();
        Console.WriteLine("Digite o sua idade:");
        aluno.Idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o seu sexo:");
        aluno.Sexo = Console.ReadLine();
        Console.WriteLine("Aprovado (S)im ou (N)ão:");
        aluno.Aprovado = Console.ReadLine();

        Curso curso = new Curso();
        curso.Resultado(aluno);
        Console.ReadKey();

    }       
}

public class Curso
{

    public void Resultado(Aluno aluno)
    {
        Console.WriteLine($"\nO aluno {aluno.Nome}, {aluno.Sexo} com {aluno.Idade} anos");
        if (aluno.Aprovado.ToLower() == "s")
        {
            Console.WriteLine("Foi aprovado");
        }
        else
        {
            Console.WriteLine("Foi reprovado");
        }
    }
}