Console.WriteLine("Metodos");


MinhaClasse minhaClasse = new MinhaClasse();

minhaClasse.Saudacao();


Console.ReadKey();

class MinhaClasse
{
    public void Saudacao()
    {
        Console.WriteLine("Bem vindo");
        ExibirDataAtual();
    }
    private void ExibirDataAtual()
    {
        Console.WriteLine($"{DateTime.Now}");
    }
}


