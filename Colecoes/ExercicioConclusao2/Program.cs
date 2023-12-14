//2- Crie um programa em C# que sirva para pesquisar um array de valores inteiros. Para fazer isso, siga estas
//etapas a seguir
//a-) Solicite via teclado o número de valores do array (deve ser um número inteiro)
//b-) Declare e inicialize um array de inteiros com a quantidade de números inteiros informados
//c-) Solicite ao usuário um valor de um número inteiro a procurar no array
//d-) Exiba se o número informado existe no array de inteiros ou não
//e-) Repita até que o texto ‘fim’ seja inserido via teclado



while (true)
{
    Console.WriteLine("Digite um numero para o tamanho da sua lista: ");
    int tamanhoDaArray = Convert.ToInt32(Console.ReadLine());

    int[] listaNumeros = new int[tamanhoDaArray];

    Random random = new Random();

    for (int i = 0; i < listaNumeros.Length; i++)
    {
        int numeroAleatorio = 0;
        do
        {
            numeroAleatorio = random.Next(1,100);
        } while (listaNumeros.Contains(numeroAleatorio));

        listaNumeros[i] = numeroAleatorio;
    }

    Console.WriteLine("\nDigite um numero para verificar se ele foi atribuido a lista: ");
    int verificaNumero = Convert.ToInt32(Console.ReadLine());

    if (listaNumeros.Contains(verificaNumero))
    {
        Console.WriteLine("O seu numero está presente na lista.");
    }
    else
    {
        Console.WriteLine("Numero não encontrado.");
    }

    Console.WriteLine("Deseja refazer a lista? (S)im / (N)ão");
    string Decisao = Console.ReadLine().ToLower();

    if (Decisao != "s")
    {
        break;
    }

}