//C# Essencial Classes e Métodos : 
//Exercício Prático 5
//t- Crie um método chamado ExibirInfo() que retorna void e que utiliza os parâmetros : Modelo, Montadora,
//Marca, Potencia e Ano e que exiba as informações destes atributos no console.
//u- Para este método defina o parâmetro Ano como opcional e faça duas chamadas ao método usando o 
//conceito de argumentos nomeados não informando o ano na primeira chamada e informando o ano na segunda 
//chamada.
//v- Explique o uso do parâmetro opcional e dos argumentos nomeados
/* Parametro Opcional serve para definirmos um valor padrao de entrada para um parametro e poder
   modifica-lo caso necessário e argumentos nomeados são utiliados para enviar os paramêtros fora da 
   ordem que o metodo o espera */


string modelo = "UNO";
string montadora = "FIAT";
string marca = "FIAT";
int potencia = 100;
int ano = 2022;


Informacoes informacoes = new Informacoes();

informacoes.ExibirInfo(montadora:montadora,marca:marca,potencia:potencia,modelo:modelo);
informacoes.ExibirInfo(modelo,montadora,marca,potencia,ano:ano);


Console.ReadKey();

public class Informacoes
{   
    public void ExibirInfo(string modelo, string montadora, string marca, int potencia, int ano = 2023)
    {
        Console.WriteLine($"As informações do carro são: modelo: {modelo}, montadora: {montadora}, " +
            $"marca: {marca}, potencia: {potencia}, ano: {ano} ");
    }
}