Console.WriteLine("Soma de numeros inteiros");


double[] valores = { 1, 2, 3 };

double x = Calcular.Soma(valores);
Console.WriteLine(x);


double valores2 = Calcular.Soma(new double[]  { 5.5, 7.3, 8.2});
Console.WriteLine(valores2);


Console.WriteLine(Calcular.Soma(1,3,4,6,7));

Console.ReadKey();

public class Calcular
{
    public static double Soma(params double[] numeros)
    {
        double resultado = 0;
        foreach (double numero in numeros)
        {
            resultado += numero;
        }
        return resultado;
    }
}