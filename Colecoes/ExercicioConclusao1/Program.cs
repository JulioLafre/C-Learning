//1 - Crie um programa C# para armazenar os nomes de 10 frutas em um array unidimensional e a seguir realize
//as seguintes operações : Dados: Maça, Banana, Laranja, Uva, Manga, Pêra, Abacate, Mamão, Pêssego, Amora
//a- Exiba os nomes das frutas no console e a quantidade de elementos do array usando os laços for e foreach
//b- Exiba os nomes da segunda e da penúltima fruta no console
//c- Altere o nome da terceira fruta para Kiwi e da última fruta para Caqui e exiba o nome de todas as frutas
//d- Ordene a coleção de frutas na ordem ascendente
//e- Exiba no console a coleção de nomes de frutas na ordem inversa

string[] listaDeFrutas = new string[10]
{
 "Maca", "Banana", "Laranja", "Uva", "Manga", "Pera", "Abacate", "Mamao", "Pessego", "Amora"
};

for(int i = 0; i < listaDeFrutas.Length; i++)
{
    Console.WriteLine($"{i + 1}° Fruta é {listaDeFrutas[i]}");
}
Console.WriteLine($"\nTamanho da lista de frutas é {listaDeFrutas.Length}\n");


foreach(var fruta in listaDeFrutas)
{
    Console.WriteLine($"Fruta é {fruta}");
}

Console.WriteLine($"\nSegunda fruta: {listaDeFrutas[1]}");
Console.WriteLine($"\nPenultima fruta: {listaDeFrutas[8]}");

listaDeFrutas[2] = "Kiwi";
listaDeFrutas[9] = "Caqui";

Console.WriteLine($"\nTerceira fruta: {listaDeFrutas[2]}");
Console.WriteLine($"\nUltima fruta: {listaDeFrutas[9]}\n");

Array.Sort(listaDeFrutas);

for(int j = listaDeFrutas.Length; j > 0; j--) { 
    Console.WriteLine($"{j}° Fruta é {listaDeFrutas[j - 1]}");
};

Console.ReadKey();