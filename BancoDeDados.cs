namespace ArmazenavelInterface;

public class BancoDeDados : IArmazenavel
{
    public string NomeBanco { get; set; }

    public void Recuperar()
    {
        Console.WriteLine($"Recuperando dados do banco de dados {NomeBanco}.");
    }

    public void Salvar()
    {
        Console.WriteLine($"Salvando dados no banco de dados {NomeBanco}.");
    }
}
