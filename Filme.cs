public class Filme 
{
    public string titulo;
    public string genero;
    public int anoLancamento;
    public int classificacaoIndicativa;

    public void ExibirInformacaos() 
    {
        Console.WriteLine("\n=== Filme Cadastrado ===");
        Console.WriteLine("Titulo: " + titulo);
        Console.WriteLine("Genero: " + genero);
        Console.WriteLine("Ano de Lançamento: " + anoLancamento);
        Console.WriteLine("Classificação: " + classificacaoIndicativa);
    }

}