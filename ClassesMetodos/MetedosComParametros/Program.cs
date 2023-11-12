Console.WriteLine("Metodos com parametros");

MinhaClase minhaClase = new MinhaClase();

minhaClase.Saudacao("Maria", DateTime.Now.ToString());

Console.ReadKey();


public class MinhaClase
{
    public void Saudacao(string nome, string data)
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);
    }
}