//Exercício Prático 6
//x- Crie um campo estático ValorIpva do tipo double que vai definir o valor percentual do IPVA cobrado para todos os carros
//y- Crie um método estático ObterValorIPVA que atribua o valor 4 ao campo ValorIpva
//z- Acesse o valor do campo ValorIpva e exiba no console. Explique o comportamento da palavra-chave static

/* O metodo Static faz com que os metodos e campos fiquem no nivel da classe e nao do objetos, podendo ser acessados sem que seja necessario instaciar um novo objeto da classe*/

Console.WriteLine("Exercicio 6");

var teste = ImpostosCarro.ObterValorIpva();
Console.WriteLine(teste);
    public class ImpostosCarro
{
    public static double ValorIpva;

    public static double ObterValorIpva()
    {
        ValorIpva = 4;
        return ValorIpva;
    }

