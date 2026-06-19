Filme filme = new Filme();

int opcao;

do
{
    Console.WriteLine("\n===CATÁLOGO DE FILMES===");
    Console.WriteLine("1 - Cadastrar filme");
    Console.WriteLine("2 - Exibir filme");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opição: ");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1;
            Console.Write("Título: ");
            filme.titulo = Console.ReadLine();

            Console.Write("Genero: ");
            filme.genero = Console.ReadLine();

            Console.Write("Ano de Lançamento: ");
            filme.anoLancamento = Convert.ToInt32(Console.ReadLine());

            Console.Write("Classificação indicativa: ");
            filme.classificacaoIndicativa = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nFilme cadastrado com susesso!");
            break;
        case 2:
            if (string.IsNullOrEmpty(filme.titulo))
            {
                Console.WriteLine("\nNenhun filme cadastraado ainda. ");
            }
            else
            {
                filme.ExibirInformacaos();
            }
            break;
        case 0:
            Console.WriteLine("\nPrograma encerrado. ");
            break;

        default:
            Console.WriteLine("\nOpição inválida. ");
            break;

    }

} while (opcao != 0);



