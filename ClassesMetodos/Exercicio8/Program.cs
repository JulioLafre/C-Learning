//Exercício Prático 8
//w3- Crie uma struct chamada Cliente e defina os campos Nome e Email do tipo string e a propriedade Idade
//do tipo int
//w4- Validar a informação da Idade de forma que se a idade informada for menor que 18 seja atribuído 18 ao 
//valor da idade.
//w5- Crie um construtor para a struct usando os campos Nome e Email e a propriedade Idade como parâmetros 
//de entrada para criar um objeto do tipo Cliente
//w6- Crie um método estático que retorne void chamado ExibirInfo que receba os parâmetros nome, email e 
//idade e exiba as informações de Nome, Email e Idade. Defina idade como um parâmetro opcional.
//w7- Crie um objeto cliente da struct Cliente usando o construtor criado e exiba as informações chamando duas 
//vezes o método ExibirInfo usando argumentos nomeados. Na primeira chamada informe todos os parâmetros e 
//na segunda não informe o ano.
//w8- Explique o que uma struct e qual a principal diferença entre struct e classe


Console.WriteLine("Exercicio8");

Cliente cliente = new Cliente("Julio","julio@teste.com",20);

Cliente.ExibirInfo("Julio","julio@teste.com",20);

Cliente.ExibirInfo("Julio", "teste@gmail.com");

Console.ReadKey();


struct Cliente
{
    string Nome;
    string Email;

    private int _idade;
    public int Idade 
    {
        get { return _idade; }
        set 
        {
            if (_idade < 18)
                _idade = 18;
            else
                _idade = value;
        }
    }

    public Cliente(string nome, string email, int idade)
    {
        Nome = nome;
        Email = email;
        Idade = idade;
    }

    public static void ExibirInfo(string nome = "Nome Padrão", string email = "Email Padrão", int idade = 0)
    {
        Console.WriteLine($"{nome}, {email}, {idade}");
    }

}