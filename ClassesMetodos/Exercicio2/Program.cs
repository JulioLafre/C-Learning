//g - Crie um construtor que permita criar um carro somente usando os atributos : Modelo e Montadora (não
//use a palavra-chave this)
//i - Crie um método chamado VelocidadeMaxima que recebe um parâmetro do tipo int chamado potencia que
//vai retornar um double representando a velocidade máxima do carro
//( Para calcular a velocidade multiplique a potencia por 1.75)

//h - Explique qual o comportamento ao usar este construtor para criar objetos do tipo Carro
/* Utilizando este construtor e possivel que seja instaciando um objeto do tipo Carro sem que seja informado
todos os seus atributos e, fazendo com seja possivel a utilizacao de seus metodos*/

//j- Explique o comportamento da palavra return
/*A palavra return permite que o programador decida o tipo e qual sera o retorno de um metodo*/


public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;


    public Carro(string? modelo, string? montadora) {
        Modelo = modelo;
        Montadora = montadora;
    }

    public Carro(string? Modelo, string? Montadora, string? Marca, int Ano, int Potencia)
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
        this.Marca = Marca;
        this.Ano = Ano;
        this.Potencia = Potencia;
    }


    public void Acelerar(string? marca)
    {
        Console.WriteLine("Acelerando" + marca);
    }


    public double VelocidadeMaxima(int potencia)
    {
        return potencia * 1.75;
    }
}