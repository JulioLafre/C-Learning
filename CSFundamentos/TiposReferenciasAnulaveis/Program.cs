Console.WriteLine("Tipos de Referencias anulaveis");

/*Se for utilizado da maneira abaixo, o compilador exibira um erro
 ao tentar executar metodos do tipo string pois o mesmo aponta para um valor
nulo, impossibilitando de realizar tal acao*/

//string nome = null;
//Console.WriteLine(nome.ToLower());

/*Caso seja necessario realizar a acao para um suposto valor, deve ser tipado da
 maneira abaixo*/

string? nome = null;
Console.WriteLine(nome?.ToLower());

Console.ReadKey();

