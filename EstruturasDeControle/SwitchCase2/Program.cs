using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Estrutura Switch-Case");

Console.WriteLine("Informe o nome do mês");
string mes = Console.ReadLine().ToLower();

switch (mes)
{
    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine("Este mês tem 31 dias");
        break;

    case "fevereiro":
        Console.WriteLine("Este mês tem 28 ou 29 dias");
        break;

    default:
        Console.WriteLine("Este mês tem 30 dias");
        break;
}

//Exemplo de Switch Case Aninhado (Evitar sempre que possível)

int funcao = 0;
Console.WriteLine("Informe (1) para gerente e (2) para programador");
int cargo = Convert.ToInt32(Console.ReadLine());

if(cargo == 2)
{
    Console.WriteLine("Informe 1 para Junior e 2 para Senior");
    funcao = Convert.ToInt32(Console.ReadLine());
}
switch (cargo)
{
    case 1:
        Console.WriteLine("Bem vindo gerente!");
        break;

    case 2:
        Console.WriteLine("Bem vindo Programador");
        switch (funcao)
        {
            case 1:
                Console.WriteLine("Você é Junior!");
                break;

            case 2:
                Console.WriteLine("Você é Senior!");
                break;

            default:
                Console.WriteLine("Função Desconhecida.");
                break;
        }
        break;

    default:
        Console.WriteLine("Não consigo te identificar.");
        break;
}

Console.ReadKey();
