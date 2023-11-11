Console.WriteLine("Exericios");

//Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior

Console.WriteLine("Digite um numero inteiro");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite outro numero inteiro");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o ultimo numero inteiro");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine($"o maior numero e {num1}");
}
else if (num2 > num3)
{
    Console.WriteLine($"o maior numero e {num2}");
}
else
{
    Console.WriteLine($"o maior numero é {num3}");
}

//2 - Escreva um programa para calcular a raiz da equação quadrática :
//-Para calcular as raízes use a fórmula de Báskara : onde
//- Considere a, b e c números inteiros (positivos, negativos e o zero)
//-Solicite a entrada de a , b e c e informe se existe ou não raiz real
//Dica: Utilize os recursos da classe Math e use a instrução if-else-if

Console.WriteLine("Informe o A");
int valorA =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o B");
int valorB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o C");
int valorC = Convert.ToInt32(Console.ReadLine());

int delta = (valorB * valorB) - 4 * valorA * valorB;


if (delta < 0)
{
    Console.WriteLine("As raizes são imaginarias");
    Console.WriteLine("Sem solução para os números reais");
}
else if (delta == 0)
{
    double x1 = -valorB + Math.Sqrt(delta) / (2 * valorA);
    Console.WriteLine("Somente uma raiz real");
    Console.WriteLine($"O valor dela é{x1}");
}
else
{
    double x1 = -valorB + Math.Sqrt(delta) / (2 * valorA);
    double x2 = -valorB - Math.Sqrt(delta) / (2 * valorA);
    Console.WriteLine("Duas raízes reais");
    Console.WriteLine($"Os valores são {x1} e {x2}");
}

Console.ReadKey();


//3 - Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma usando os loop 
//while, do-while e for

int i = 0;
while (i < 10)
{
    Console.WriteLine(i);
    i++;
}

for(int k = 0; k <= 10; k++)
{
    Console.WriteLine(k);
}

int j = 0;
do {
    Console.WriteLine(j);
    j++;
}
while (j <= 10);

Console.ReadKey();


//4 - Escreva um programa para exibir a tabela de multiplicação de um número natural maior que zero
//recebido via teclado
//- Verifique se o número é maior que zero e emita uma mensagem
//- Considere a tabela de multiplicação de 1 até 10
//- Após exibir a tabela torne a solicitar outro número
//- Para sair do loop defina uma condição de saída
//Dica: Use os loop while e for e para sair a instrução break

while (true)
{
    Console.WriteLine("Digite um número para exibir sua tabela de multiplicacao e 0 para sair ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num < 0) {
        Console.WriteLine("Voce digitou um numero inválido");
        continue;
    }

    else if (num == 0) {
        break; 
    }

    Console.WriteLine($"Tabuada de {num}");
    for (int ind = 1; ind <=10; ind++)
    {
        Console.WriteLine($"{num} * {ind} = {num * ind}");
    }
}





//5 - Escreva um programa para solicitar ao usuário que escolha a resposta correta de uma lista de opções de 
//resposta de uma pergunta. O usuário pode optar por continuar respondendo a pergunta ou parar de responder.
//Não utilize a instrução break.

string resposta;
bool condicao = true;
Console.WriteLine("Qual a instrução para sair de um loop ?");
Console.WriteLine("a.quit");
Console.WriteLine("b.continue");
Console.WriteLine("c.break");
Console.WriteLine("d.exit");
while (condicao)
{
    Console.WriteLine("\nQual a opção correta ? (Tecle x para sair)");
    resposta = Console.ReadLine().ToLower();
    if (resposta == "c")
    {
        Console.WriteLine("Resposta Correta !");
        condicao = false;
    }
    else if (resposta == "x")
    {
        Console.WriteLine("Programa encerrado..");
        condicao = false;
    }
    else
    {
        Console.WriteLine("Resposta Incorreta !!!");
    }
}


//6 - Crie um programa para exbir no console os números pares de 10 a 20, ambos incluídos, exceto 16, de 3 
//maneiras diferentes:

for (int hj = 10; hj <= 20; hj += 2)
{
    if (hj % 2 != 0 || hj == 16)
    {
        continue;
    }

    Console.WriteLine($"{hj}");
}

Console.ReadKey();

for (int hj = 10; hj <= 20; hj++)
{
    if (hj % 2 != 0 || hj == 16)
    {
        continue;
    }

    Console.WriteLine($"{hj}");
}

Console.ReadKey();


int hnk = 10;
while (hnk >= 20)
{
    if (hnk % 2 != 0 || hnk == 16)
    {
        continue;
    }

    Console.WriteLine($"{hnk}");
    hnk++;
}

Console.ReadKey();
//7 - Escreva um programa para exibir o padrão como triângulo de ângulo reto usando asterisco (*). Ex:
//*
//**
//***
//****

int bab, beb, linhas;
Console.WriteLine("Informe a quantidade de linhas");
linhas = Convert.ToInt32(Console.ReadLine());

for(bab = 1; bab<=linhas; bab++)
{
    for(beb = 0; beb<=bab; beb++)
    {
        Console.Write("*");
    }
    Console.Write("\n");
}
Console.ReadLine();



//8 - Escreva um programa para calcular o fatorial de um número inteiro. 
//O fatorial de um número é representado por : n! => n * (n – 1) *(n – 2) ....2 * 1
//Exemplo: fatorial de 6 é representado por 6! = 6*5*4*3*2*1

int novovalor = 1;
int numfatorial;
Console.WriteLine("Digite um numero para saber o seu fatorial");
numfatorial = Convert.ToInt32(Console.ReadLine());

for (int iterador2 = 1; iterador2 <= numfatorial; iterador2++)
{
    novovalor = novovalor * iterador2;
}
Console.WriteLine($"{novovalor}");


//9 - Escreva um programa para exibir as tabelas de multiplicação do 2 ao 6 usando o loop do-while aninhado

int controle1 = 1;

do
{
    int controle2 = 1;
    do
    {
        Console.WriteLine($"{controle1} * {controle2} = {controle1 * controle2}");
        controle2++;
    }
    while (controle2 <= 10);
    controle1++;
    Console.WriteLine();
}
while (controle1 <= 6);


//10 - Crie um programa que recebe na entrada de dados um número inteiro de 0 a 10 que representa a nota de 
//um aluno. Com base na tabela a seguir imprima no console qual o resultado da avaliação do aluno. (Use a 
//instrução switch, break e default em um loop infinito e defina uma condição de saida.)

while (true)
{
    Console.WriteLine("Digite a nota do aluno (0 sai)");
    int notaAluno = Convert.ToInt32(Console.ReadLine());
    if (notaAluno == 0)
    {
        break;
    }
    Console.WriteLine("Resultado da avaliação");
    switch (notaAluno)
    {
        case 10:
            Console.WriteLine("A+");
            break;
        case 9:
            Console.WriteLine("A");
            break;
        case 8:
        case 7:
            Console.WriteLine("B");
            break;
        case 6:
            Console.WriteLine("C");
            break;
        case 5:
            Console.WriteLine("F");
            break;
        default:
            Console.WriteLine("F");
            break;
    }
}


//11 - Crie um programa para realizar as operações de adição, subtração, multiplicação e divisão de números 
//inteiros. (considere que na divisão podemos ter números fracionários e que não existe divisão por zero e 
//quando isso ocorrer exibir uma mensagem de alerta


Console.WriteLine("Informe o primeiro numero");
double primeiNumero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o operador(+,-,*,/)");
string operador = Console.ReadLine();
Console.WriteLine("Informe o segundo numero");
double segundNumero = Convert.ToInt32(Console.ReadLine());

if (operador == "+")
{
    Console.WriteLine($"{primeiNumero + segundNumero}");
}
else if(operador == "-") 
{
    Console.WriteLine($"{primeiNumero - segundNumero}");
}
else if (operador == "*") 
{ 
    Console.WriteLine($"{primeiNumero * segundNumero}");
}
else if (operador == "/")
{

    if (segundNumero == 0)
    {
        Console.WriteLine("Não exite divisão por 0");
    }
    else {
        Console.WriteLine($"{primeiNumero - segundNumero}"); 
    }
}