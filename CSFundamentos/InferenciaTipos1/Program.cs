Console.WriteLine("## Inferencia de tipos (var) ##\n");

var idade = 25;
var nome = "Maria";
var salario = 2500.00m;

Console.WriteLine($"{nome} tem {idade} anos e ganha {salario.ToString("c")}");


//var limitações
//var salario = null;
//var titulo;
//var salario, titulo, ano;

// tambem nao pode mudar tipos apos inicializada
//var num = 10;
//num = "teste";

var teste = new Teste();
teste.MeuMetodo();


class Teste
{
    public void MeuMetodo()
    {
        Console.WriteLine("Meu método");
    }

}

Console.ReadKey();