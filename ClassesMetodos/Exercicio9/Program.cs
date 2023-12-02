//Exercício Prático 9
//- Crie uma enumeração chamada Cores em um arquivo CarroEnum.cs que defina os seguintes membros : 
//Branco, Vermelho, Preto, Cinza, Prata e Azul
//- Inicie o valor da enumeração com 1
//- Inclua na classe Carro o campo Cor do tipo int que vai representar a cor do carro
//- Defina um menu de opções exibindo o nome da Cor e o seu valor 
//- Receba a seleção do usuário em uma variável do tipo int cor que vai ser usada para atribuir ao campo Cor
//- Altere o método ExibirInfo() incluindo o parâmetro cor do tipo int como parâmetro opcional e exiba o nome da 
//cor a partir do valor da Cor recebida
//- Altere o construtor da classe incluindo o campo Cor para criar objetos usando a Cor selecionada

Console.WriteLine("Exercicio 9");

Console.WriteLine($"{Cores.Branco} - {(int)Cores.Branco}");
Console.WriteLine($"{Cores.Vermelho} - {(int)Cores.Vermelho}");
Console.WriteLine($"{Cores.Preto} - {(int)Cores.Preto}");
Console.WriteLine($"{Cores.Cinza} - {(int)Cores.Cinza}");
Console.WriteLine($"{Cores.Prata} - {(int)Cores.Prata}");
Console.WriteLine($"{Cores.Azul} - {(int)Cores.Azul}");
Console.WriteLine("\nSelecione a Cor do carro");
int cor = Convert.ToInt32(Console.ReadLine());
//chevrolet
Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110, cor);
chevrolet.ExibirInfo(chevrolet.Modelo, chevrolet.Montadora, chevrolet.Marca, chevrolet.Potencia, chevrolet.Ano, chevrolet.Cor);
Console.ReadKey();


enum Cores
{
    Branco = 1,
    Vermelho,
    Preto,
    Cinza,
    Prata,
    Azul
}


class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;
    public int Cor;

    public Carro(string? Modelo, string? Montadora, string? Marca,
        int Ano, int Potencia, int Cor)
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
        this.Marca = Marca;
        this.Ano = Ano;
        this.Potencia = Potencia;
        this.Cor = Cor;
    }

    public void ExibirInfo(string? Modelo, string? Montadora, string? Marca,
        int Potencia, int Ano = 2022, int Cor = 1)
    {
        Console.WriteLine(Modelo);
        Console.WriteLine(Montadora);
        Console.WriteLine(Marca);
        Console.WriteLine(Potencia);
        Console.WriteLine(Ano);
        Console.WriteLine((Cores)Cor);
    }
}