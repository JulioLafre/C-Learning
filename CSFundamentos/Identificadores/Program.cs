using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Definindo Identificadores");

//Identificadores Válidos
string nome;
string nomeCompleto;
int idade;
int _valor;
int idade2;

//Identificadores inválidos
//int5idade;
//int$idade;
//intvalor#total;
//stringnomeCompleto;


//para constantes: caracteres maiúsculos
double PI = 3.14;
string PREFIXO_SP = "11";


//para nomes de variaveis: camelCase
string descontoTotal;
string desconto_Total;

//para nome de classes e metodos: PascalCase
class ImprimirTexto
{
    public void ImprimeNome()
    {
        Console.WriteLine("Teste");     
    }
}
 
Console.ReadLine();