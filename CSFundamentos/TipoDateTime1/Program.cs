Console.WriteLine("## Struct DateTime ##\n");

DateTime dataAtual =  DateTime.Now;
Console.WriteLine($"hoje: {dataAtual}\n");


//extraindo informacoes da data atual
Console.WriteLine("\nExtraindo Informações: ");
Console.WriteLine(dataAtual.Year);
Console.WriteLine(dataAtual.Month);
Console.WriteLine(dataAtual.Day);
Console.WriteLine(dataAtual.Hour);
Console.WriteLine(dataAtual.Minute);
Console.WriteLine(dataAtual.Second);
Console.WriteLine(dataAtual.Millisecond);


//adicionando valores na data atual
Console.WriteLine("\nAdicionando Valores: ");
Console.WriteLine(dataAtual.AddDays(30));
Console.WriteLine(dataAtual.AddMonths(1));
Console.WriteLine(dataAtual.AddHours(2));
Console.WriteLine(dataAtual.AddYears(5));


//obter o dia da semana e do ano
Console.WriteLine("\nObtendo valores específicos: ");
Console.WriteLine(dataAtual.DayOfWeek);
Console.WriteLine(dataAtual.DayOfYear);


//data no formato longo e curto
Console.WriteLine("\nObetendo Valores:");
Console.WriteLine(dataAtual.ToLongDateString());
Console.WriteLine(dataAtual.ToShortDateString());
Console.WriteLine(dataAtual.ToLongTimeString());
Console.WriteLine(dataAtual.ToShortTimeString());



//criar uma data especifica usa formato: aaaa,mm,dd
DateTime dataHoje = new DateTime(2022, 09, 06);
Console.WriteLine(dataHoje);


//Definir as horas
DateTime dataHoraHoje = new DateTime(2022, 09, 06, 21, 10 , 30);
Console.WriteLine(dataHoraHoje);

Console.ReadLine();