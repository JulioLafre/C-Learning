Console.WriteLine("Construtores");


Aluno aluno = new Aluno("teste", 20, "teste", "teste");

Console.WriteLine(aluno.Nome == null ? "null" : aluno.Nome);
Console.WriteLine(aluno.Idade == 0 ? "zero" : aluno.Idade);
Console.WriteLine(aluno.Sexo == null ? "null" : aluno.Sexo);
Console.WriteLine(aluno.Aprovado == null ? "null" : aluno.Aprovado);

Console.ReadLine();

public class Aluno
{
    public Aluno(string nome)
    {
        Nome = nome;
    }

    public Aluno(string nome, int idade, string sexo, string aprovado):this(nome)
    {
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }  

    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;

}
