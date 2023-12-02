Console.WriteLine("Tipos Anonimos");

var pessoa = new
{
    Id = 1,
    Nome = "Jairo",
    Email = "Jairo@email.com",
    Enderco = new {Id = 1, Cidade = "Santos", Pais = "Brasil"}
};

Console.WriteLine(pessoa.Nome);
Console.WriteLine(pessoa.Enderco.Cidade);

var alunos = new[]
{
    new { Id = 1, nome = "Maria", Email = "maria@email.com"},
    new { Id = 2, nome = "Joao", Email = "joao@email.com"},
    new { Id = 3, nome = "Pedro", Email = "pedro@email.com"}
};

Console.WriteLine(alunos[0].nome);
Console.WriteLine(alunos[1].Email);

Console.ReadKey();
