//1 - Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato : 
//Aluno<nome> tem<idade> anos e nota<nota> usando a concatenação e a interpolação de strings

string nome = "Paulo";
int idade = 17;
float nota = 7.5f;

Console.WriteLine($"Aluno {nome} tem {idade} anos e nota {nota}");

Console.ReadKey();

//2 - Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de 
//escapes

Console.WriteLine($"Aluno {nome}\n tem {idade} anos\n e nota {nota}\n");

Console.ReadKey();

//3 - Para qual tipo de dados você pode converter um float implicitamente ?
//( ) int
//( x ) double
//( ) long
//( x ) decimal

//4 - Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
//( ) int para long
//( x ) double para long
//( x ) double para float
//( x ) decimal para float
//( x ) long para int
//( ) double para decimal

//5 - Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando 
//a concatenação e também a interpolação de strings

Console.WriteLine("Digite uma letra:");
char letra1 = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Digite uma letra:");
char letra2 = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Digite uma letra:");
char letra3 = Convert.ToChar(Console.ReadLine());

Console.WriteLine(letra3 + " " + letra2 + " " + letra1);
Console.WriteLine($"A ordem inversa das letras digitadas é: {letra3}, {letra2}, {letra1}");

Console.ReadKey();

//6 - Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
//( F ) long resultado = 1.32;
//( V ) var nome = “Maria”;
//( V ) string resultado = 100.ToString();
//( V ) A sequência de escape \n inclui uma nova linha
//( F ) float f = 5.45;
//( V ) decimal valor = (decimal)10.99f;
//( F ) var status = null;
//( V ) object o = 12.45m;
//( V ) string titulo = true.ToString();
//( F ) A sequencia \t inclui uma tabulação vertical


//7 - Escreva um programa para receber dois valores via teclado do tipo double e a seguir 
//realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo 
//exibindo o resultado:'

Console.WriteLine("Digite um numero:");
double numero1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite outro numero:");
double numero2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Soma de {numero1} + {numero2} = {numero1 + numero2}");
Console.WriteLine($"Subtracao de {numero1} - {numero2} = {numero1 - numero2}");
Console.WriteLine($"Multiplicação de {numero1} * {numero2} = {numero1 * numero2}");
Console.WriteLine($"Exponenciação de {numero1} ^ {numero2} = {Math.Pow(numero1, numero2)}");
Console.WriteLine($"Divisão de {numero1} / {numero2} = {numero1 / numero2}");
Console.WriteLine($"Módulo de {numero1} % {numero2} = {numero1 % numero2}");

Console.ReadKey();
//8 - Faça um programa para calcular o resultado da fórmula de baskara dados os valores de 
//a b e c .

int a = 1, b = 12, c = -13;

double baskhara1 = (-b + Math.Sqrt(Math.Pow(b, 2) -4 * a * c)) / 2 * a;
double baskhara2 = (-b - Math.Sqrt(Math.Pow(b, 2) -4 * a * c)) / 2 * a;
Console.WriteLine($"{baskhara1}, {baskhara2}");

Console.ReadKey();

//9 - Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e 
//Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’ 
//então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login 
//inválido’: (use o operador condicional ternário

Console.WriteLine("Digite o seu nome:");
string nome_pessoa = Console.ReadLine();
Console.WriteLine("Digite a sua senha:");
string senha_pessoa = Console.ReadLine();

string bypass = (nome_pessoa == "admin" || nome_pessoa == "maria") && senha_pessoa == "123" ? 
             "Login feito com sucesso" : "Login inválido";

Console.WriteLine(bypass);

Console.ReadKey();


//10 - Indique verdadeiro(V) ou falso(F) para as seguintes declarações de variáveis considerando 
//a nomenclatura usada:
//( V ) string? nome; é um exemplo de nullable reference type;
//( F ) para x igual a 0 , Console.WriteLine(x++); imprime o valor 1
//( F ) A ordem de precedência dos operadores lógicos é : ! , || e && (NOT, OR e AND)
//( V ) para y igual a 0 , Console.WriteLine(++y); imprime o valor 1
//( F ) (10 % 2 == 0) ? “Par” : “Impar”; Vai retornar “Impar”
//( F ) Para x = 25 e y=5 , a expressão ( y >= x ) && (y <= x); retorna true;
//( V ) Os nullable reference types emitem um alerta em tempo de compilação para uso do null
//( F ) Para x = 10, o código Console.WriteLine(x+=x); imprime o valor 10;
//( F ) Para x = 5, a expressão !(9 >= x) && x <= 7 || x == 5); retorna false;
//( V ) O operador ?. permite verificar se um objeto é null e evitar o NullReferenceException
//( V ) Qualquer tipo de dado pode ser declarado como anulável com a ajuda do operador "?"


//11 - Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no 
//console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)

Console.WriteLine("Digite um numero");
int numint1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite outro numero");
int numint2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(numint1 % 2 == 0? " primeiro numero é par": "primeiro numero é impar");
Console.WriteLine(numint2 % 2 == 0? "segundo numero é par": "segundo numeroé impar");

//12 - Crie um programa que receba um numero inteiro x via teclado e calcule e imprima no 
//console o resultado das seguintes operações : (x ^ 2->x ao quadrado) (pi = 3.1415)
//- 6 + x * 5
//(13 - 2) * x
//(x + -2) * (20 / x)
//(12 + x) / (x - 4)
//3 x ^ 2 + x + 10
//pi* x^2

Console.WriteLine("Digite um numero");
int numero_Base_Calculo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(-6 + numero_Base_Calculo * 5);
Console.WriteLine((13 - 2) * numero_Base_Calculo);
Console.WriteLine((numero_Base_Calculo + -2) * (20 / numero_Base_Calculo));
Console.WriteLine((12 + numero_Base_Calculo) / (numero_Base_Calculo - 4));
Console.WriteLine(3 * Math.Pow(numero_Base_Calculo,2) + numero_Base_Calculo + 10);
Console.WriteLine(Math.PI * Math.Pow(numero_Base_Calculo,2));

// 13 - Considere o seguinte trecho de código:
// int y = 5;
// y = (y++) + y + (++y); ou y = y++ + y + ++y;
int e = 5;
e = (e++) + e + (++e);
Console.WriteLine(e);


//14 - Escreva um programa que solicite a temperatura em graus Celsius e converta para 
//Kelvin e Farhenheit usando as fórmulas a seguir:
//-Converter para Kelvin => K = C + 273;
//-Converter para Farhenheit => F = (C * 9) / 5 + 32;

Console.WriteLine("Informe a temperatura em celsius");
double celsius = Convert.ToDouble(Console.ReadLine());

double converter_Kelvin = celsius + 273;
double converter_Farhenheit = (celsius * 9) / 5 + 32;

Console.WriteLine($"A temperatura em Kelvin é {converter_Kelvin}");
Console.WriteLine($"A temperatura em Kelvin é {converter_Farhenheit}");

// 15 - Escolha a opção que representa a exibição do resultado para o código usando os 
// operadores de decremento e incremento (pré e pós): 
// R: 5 2 2 2

