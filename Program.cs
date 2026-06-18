Filme filme = new Filme();

Console.Write("Título: ");
filme.titulo = Console.ReadLine();

Console.Write("Genero: ");
filme.genero = Console.ReadLine();

Console.Write("Ano de Lançamento: ");
filme.anoLancamento = Convert.ToInt32(Console.ReadLine());

Console.Write("Classificação indicativa: ");
filme.classificacaoIndicativa = Convert.ToInt32(Console.ReadLine());

filme.ExibirInformacaos();