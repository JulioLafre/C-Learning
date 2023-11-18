//C# Essencial Classes e Métodos : 
//Exercício Prático 4
//r- Crie um método AumentarPotenciaVelocidade que recebe o parâmetro int potencia e retorna um int
//como valor da nova potência. Neste método use parâmetro out e passe a variável velocidade e que vai 
//retornar a nova velocidade como um double.
//(incremente a potência de 7 e calcule a nova velocidade multiplicando a potência por 1.75)
//s - Faça a chamada ao método exibindo os valores da nova potencia e da nova velocidade e explique o 
//comportamento do parâmetro out.

int potencia = 10;

Carro carro = new Carro();

Console.WriteLine(potencia);

carro.AumentarPotenciaVelocidade(ref potencia, out double velocidade);

Console.WriteLine(potencia);
Console.WriteLine(velocidade);

Console.ReadKey();

public class Carro
{
    public int AumentarPotenciaVelocidade(ref int potencia, out double velocidade)
    {
        potencia += 7;
        velocidade = potencia * 1.75;
        return potencia;
    }
}