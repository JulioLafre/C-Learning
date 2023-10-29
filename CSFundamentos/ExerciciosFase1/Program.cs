/*Exercícios fase 1
1- Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor.*/

int idade = 35;
Console.WriteLine(idade);

//2- Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor.
string nome = "Maria";
Console.WriteLine(nome);

//3- Crie uma variável chamada altura e atribua a ela o valor 3.45.
float altura = 3.45f;

//4- Crie uma variável chamada data e atribua a ela a data 04/09/1999 e exiba o seu valor
DateTime data = new DateTime(1999,09,04);
Console.WriteLine(data);

//5 - Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor;
const int ANO = 12;
Console.WriteLine(ANO);

/* - Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o 
valor 7.80 e exiba o seu valor.*/
double? nota = 7.80;
Console.WriteLine(nota);

//7- Quais as diferenças entre os tipos por valor e os tipos por referência 
/* Tipos por valor: ficam localizados na stack e realizam cópias idependentes, rápido acesso e
possui um ciclo de vida referente ao escopo declarado*/
/* Tipos por Referência: ficam localizados na heap e compartilham a mesma instancia, mais flexiveis e
possuem um ciclo de vida mais longo*/

//8 - Inclua o tipo de dados correto entre os parênteses nas seguintes declarações de variáveis:
//( int ) x = 10;
//( double ) numero = 7.99;
//( char ) letra = 'C';
//( float ) temperatura = 27.4f;
//( bool ) ativo = false;
//( strin ) nome = "Manoel";
//( decimal ) salario = 950.99m;
//( DateTime ) hoje = DateTime.Now

//9 - Dada as variáveis declaradas a seguir classifique-as em tipos por valor(V) e tipos por 
//referência (R) :
//( V ) int n = 1;
//( R ) string titulo = "A vida";
//( V ) float f = 12.45f;
//( V ) double d = 5.45;
//( V ) decimal valor = 10.99m;
//( V ) char sexo = ‘M’;
//( R ) object o = null;

//10 - O que é um nullable type e qual a sua utilidade ?
/* Nullable type em C# e a maneira de referenciar a um tipo de valor que o mesmo pode obter o valor
null, já que por padrão os tipos de valor não possuem essa possiblidade de retorno*/

//11- O que é Camel Case ? Dê um exemplo de sua aplicação.
/* camelCase é um metódo para organização de código onde, em C#, consiste em atribuir a nomes de variáveis
um padrão onde a primeira letra começa sendo mínúscula e caso tenha alguma separação de palavras, a próxima
será maiúscula. Exemplos do uso: nomeCompleto, primeiraLetraDoSobrenome, valorAReceber*/

//12- O que é Pascal Case ? Dê um exemplo de sua aplicação
/* Semelhante ao camelCase, o PascalCase também e um metódo para organização de código onde, em C#, consiste em
 atribuir a nomes de classes e metodos um padrão para que cada palavra inicie com a letra maiúscula.
Exemplos de uso: CalcularImposto, PegarPrimeiroItemDaLista, RetornaNomeCompleto*/

//13 - Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a 
//seguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a 
//operação de soma)
int x = 77;
int y = 66;
Console.WriteLine(x + y);

//14 - Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e 
//string
// Bool: False
// char: \0 ou (U+000)
// int, double, float e decimal: 0
// string: null

//15 - Indique verdadeiro(V) ou falso(F) para as seguintes declarações de variáveis 
//considerando a nomenclatura usada:
//( F ) double 1valor = 12.45;
//( F ) string #nome = "Pedro"; 
//( V ) float _temperatura = 12.45f;
//( F ) double int = 5;
//( F ) decimal renda extra = 91.45m;
//( F ) bool status$conta = false;
//( V ) string titulo3 = “Tópico 1”;
//( V ) float salario_mensal = 1999.55f;
//( V ) int percentualValorDesconto = 5;
//( V ) const bool MENSALIDADE_EM_DIA = true;



Console.ReadKey();


