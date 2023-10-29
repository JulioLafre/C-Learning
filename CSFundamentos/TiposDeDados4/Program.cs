Console.WriteLine("Definindo variáveis do tipo string, object e dynamic");
Console.WriteLine();\

string nome = "Curos de c#";
String titulo = "Curso de C# Essencial";

Console.WriteLine(nome);
Console.WriteLine(titulo);

Console.ReadLine();

// não é correto utilizar o tipo string para se trabalhar com alterações de texto
// pois elas salvam cada alteracao e um novo local da memoria
string valor = "Isto é uma string";
valor = "Alterando valor da string";
valor = "teste";

//O correto a se utilizar é o Metodo StringBuilder

object nota = 10;
object valor1 = 8.55m;
object nome1 = "Maria";
dynamic ativa = true;
dynamic letra = 'A';

Console.WriteLine(nota);
Console.WriteLine(valor1);
Console.WriteLine(ativa);
Console.WriteLine(letra);

Console.ReadLine();