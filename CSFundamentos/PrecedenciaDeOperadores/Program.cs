Console.WriteLine("Precedencia de Operadores");

// parecido com regras matematicas, parenteses tem prioridade acima de operadores

int x = 10 - 2 * 3;
Console.WriteLine(x);

x = (10 -2) * 3;
Console.WriteLine(x);

/* Regra de precedencia com Operadores Logicos, !(NOT) tem a maior prioridade, &&(AND) 
tem prioridade intermediara e || tem a menor prioridade */

bool b = !(9 != 8) && 5 >= 7 || 8 >= 6;
Console.WriteLine(b);

b = !(9 != 8) && (5 >= 7 || 8 >= 6);
Console.WriteLine(b);

/* Operadores de Incremento possuem a maior ordem de prioridade antes dos parenteses onde,
os de decremento possuem prioridade acima dos de incremento */

int k = 5, l = 6, m = 4;
int r = --k * l - ++m;
Console.WriteLine(r);


Console.ReadKey();