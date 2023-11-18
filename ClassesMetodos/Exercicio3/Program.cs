//C# Essencial Classes e Métodos : 
//Exercício Prático 3
//l- Crie um método chamado AumentarPotencia que recebe um parâmetro do tipo int por valor chamado 
//potencia e retorna um int representando o aumento de potencia.
//(para aumentar a potência incremente 3 ao parâmetro recebido)
//m - Invocar o método criado e passar o valor do argumento por valor e exibir os valores. Explique o 
//comportamento da passagem do argumento por valor
//n- Crie uma sobrecarga para o método AumentarPotencia que recebe um parâmetro do tipo int por referência
//chamado potencia e retorna um int representando o aumento de potencia.
//(para aumentar a potência incremente 5 ao parâmetro recebido)
//p - Invocar o método e passar o valor do argumento por referência e exibir os valores. Explique o 
//comportamento da passagem do argumento por referência.
//o- Explique a sobrecarga de métodos


int potencia = 10;

Potencia poten = new Potencia();

poten.AumentarPotencia(potencia);

Console.WriteLine($"Valor da potencia: {potencia}");
/*O vakor de potencia não foi alterado na mémoria porque a passagem por valor não realiza isso,
 o que aconteceu foi que na funcao AumentarPotencia foi passada uma copia do valor de x como argumento*/

poten.AumentarPotencia(ref potencia);

Console.WriteLine($"Valor da potencia: {potencia}");
/* Dessa vez o valor da potencia foi alterado porque foi feita uma referencia ao endereco de memoria de
 onde o valor esta alocado, modificando assim o valor original*/


class Potencia
{
    public void AumentarPotencia(int potencia)
    {
        potencia += 3;
        Console.WriteLine($"Valor aumentado da potencia: {potencia}");

    }

    public void AumentarPotencia(ref int potencia)
    {
        potencia += 5;
        Console.WriteLine($"Valor aumentado da potencia: {potencia}");
    }
    /* Sobrecarga de métodos permite criarmos um outro método com o mesmo nome dentro de uma classe e fazer com que ele tenha
     comportamentos, valores e parametros diferentes*/


}