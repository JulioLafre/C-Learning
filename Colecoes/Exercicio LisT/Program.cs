GerenciarAlunos gerenciadorDeAlunos = new GerenciarAlunos();

gerenciadorDeAlunos.AdicionarAluno(new Aluno("Maria", 8.75));
gerenciadorDeAlunos.AdicionarAluno(new Aluno("Manoel", 6.95));
gerenciadorDeAlunos.AdicionarAluno(new Aluno("Amanda", 7.25));
gerenciadorDeAlunos.AdicionarAluno(new Aluno("Carlos", 6.55));
gerenciadorDeAlunos.AdicionarAluno(new Aluno("Jaime",8.50));
gerenciadorDeAlunos.AdicionarAluno(new Aluno("Debora",5.95));
gerenciadorDeAlunos.AdicionarAluno(new Aluno("Alicia", 9.25));
gerenciadorDeAlunos.AdicionarAluno(new Aluno("Sandra", 5.55));
gerenciadorDeAlunos.AdicionarAluno(new Aluno("Marta", 7.85));
gerenciadorDeAlunos.AdicionarAluno(new Aluno("Sueli", 9.15));
gerenciadorDeAlunos.AdicionarAluno(new Aluno("Bia", 7.75));
gerenciadorDeAlunos.AdicionarAluno(new Aluno("Mario", 8.95));

gerenciadorDeAlunos.LocalizarAlunoExistente("Amanda");
gerenciadorDeAlunos.RemoverAlunoPeloNome("Amanda");

gerenciadorDeAlunos.ExibirAlunos();
gerenciadorDeAlunos.ExibirAlunosComNotaMinima();

Console.ReadKey();

public class Aluno : IComparable<Aluno>
{
    public string Nome { get; set; }
    public double Nota { get; set; }

    public Aluno(string nome, double nota)
    {
        Nome = nome;
        Nota = nota;
    }

    public int CompareTo(Aluno other)
    {
        // Compara os alunos pelo nome
        return this.Nome.CompareTo(other.Nome);
    }
}


public class GerenciarAlunos
{
    private List<Aluno> alunos = new List<Aluno>();

    public void AdicionarAluno(Aluno aluno)
    {
        alunos.Add(aluno);
    }


    public void LocalizarAlunoExistente(string nome)
    {
        var encontrados = alunos.FindAll(aluno => aluno.Nome == nome); // poderia ter feito alunmo.Nome.Equals("nome do aluno")
        if (encontrados.Count > 0)
        {
            Console.WriteLine($"Alunos encontrados com o nome {nome}:");
            foreach (var aluno in encontrados)
            {
                Console.WriteLine($"Nome: {aluno.Nome}, Nota: {aluno.Nota}");
            }
        }
        else
        {
            Console.WriteLine($"Nenhum aluno encontrado com o nome {nome}.");
        }
    }

    public void RemoverAlunoPeloNome(string nome)
    {
        alunos.RemoveAll(aluno => aluno.Nome == nome);
    }

    public void ExibirAlunos()
    {
        alunos.Sort();
        double SomaDasNotasDosAlunos = 0;
        foreach (var aluno in alunos)
        {
            SomaDasNotasDosAlunos += aluno.Nota;
            Console.WriteLine($"Nome: {aluno.Nome}, Nota: {aluno.Nota}");
        }
        Console.WriteLine($"\nMédia final dos alunos: {SomaDasNotasDosAlunos / alunos.Count}");
        Console.WriteLine($"\nQuantidade total de alunos na lista: {alunos.Count}");
    }

    public void ExibirAlunosComNotaMinima()
    {
        foreach (var aluno in alunos)
        {
            if (aluno.Nota > 8)
            {
                Console.WriteLine($"Nome: {aluno.Nome}, Nota: {aluno.Nota}");
            }
        }
    }

}
