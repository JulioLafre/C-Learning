using System.Collections;

ArrayList lista = new ArrayList();
lista.Add(3);
lista.Add(4);

var elemento = lista[0]; // Realiza a operacao de unboxing

int numero = (int)lista[1]; // Tambem realiza a operacao de unboxing

List<int> lista2 = new List<int>();

lista2.Add(4);

var numero2 = lista2[0]; // Nao realiaz operacao de unboxing, pois a lista ja pertence ao tipo da variavel


    
