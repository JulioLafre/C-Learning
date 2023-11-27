//Exercício Prático 7
//w- Substituir na classe Carro o campo Ano por uma propriedade de mesmo nome e mesmo tipo.
//w1- Validar a informação do Ano de forma que se o ano informado for menor que 2000 seja atribuído 2000 e se
//for informado maior que 2022 seja atribuído 2022 ao valor do ano.
//w2- Explicar a diferença entre campo e propriedade.


/*Um campo é uma variável de qualquer tipo que é declarada diretamente na classe
Uma propriedade é um membro que fornece um mecanismo flexível para ler, gravar ou calcular o valor de um 
campo privado*/


Console.WriteLine("Hello, World!");

public class Carro
{
    private int ano;
    public int Ano
    {
        get { return ano; }

        set {
            if (value < 2000)
                ano = 2000;
            else if (value > 2022)
                ano = 2022;
            else
                ano = value;
            }
    }
}


