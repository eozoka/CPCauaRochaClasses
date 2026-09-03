using CPCauaRochaClasses;

List<Jogo> jogos = new List<Jogo>();

String continuar = "s";

while (continuar == "s")
{
    Console.WriteLine("Cadastrador de Jogos!");

    String nome = " ";

    while (string.IsNullOrWhiteSpace(nome))
    {
        Console.WriteLine("Digite o nome do jogo: ");
        nome = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("O nome nao pode ficar vazio!");
        }
    }

    bool dataValida = false;
    int dataLancamento = 0;

    while (!dataValida)
    {
        Console.WriteLine("Digite o ano de lancamento do jogo: ");

        try
        {
            dataLancamento = int.Parse(Console.ReadLine());
            dataValida = true;
        }
        catch (FormatException)
        {
            Console.WriteLine("Digite uma data valida!");
        }
    }

    Console.WriteLine("Digite a desenvolvedora do Jogo: ");
    String desenvolvedora = Console.ReadLine();

    int idadeIndicativa = 0;
    bool idadeValida = false;

    while (!idadeValida)
    {
        Console.WriteLine("Digite a idade indicativa do jogo: ");

        try
        {
            idadeIndicativa = int.Parse(Console.ReadLine());
            idadeValida = true;
        }
        catch (FormatException)
        {
            Console.WriteLine("Sao aceitos apenas numeros!");
        }
    }

    double preco = 0;
    bool precoValida = false;

    while (!precoValida)
    {
        Console.WriteLine("Digite o preco do Jogo: ");

        try
        {
            preco = double.Parse(Console.ReadLine());
            precoValida = true;
        }
        catch (FormatException)
        {
            Console.WriteLine("Digite apenas numeros!");
        }
    }

    Console.WriteLine("Digite o genero do Jogo: ");
    String genero = Console.ReadLine();

    Console.WriteLine("Digite o tipo de terror do Jogo: ");
    String tipoTerror = Console.ReadLine();

    int nivelMedo = 0;
    bool nivelMedoValida = false;

    while (!nivelMedoValida)
    {
        Console.WriteLine("Digite o nivel de medo do Jogo: ");

        try
        {
            nivelMedo = int.Parse(Console.ReadLine());
            nivelMedoValida = true;
        }
        catch (FormatException)
        {
            Console.WriteLine("Digite apenas numeros!");
        }
    }

    bool possuiJumpscares = false;
    bool possuiJumpscaresValida = false;

    while (!possuiJumpscaresValida)
    {
        Console.WriteLine("O jogo possui jumpscares?: ");

        try
        {
            possuiJumpscares = bool.Parse(Console.ReadLine());
            possuiJumpscaresValida = true;
        }
        catch (FormatException)
        {
            Console.WriteLine("Insira apenas true ou false!");
        }
    }

    JogoTerror jogo = new JogoTerror(
        nome,
        dataLancamento,
        desenvolvedora,
        idadeIndicativa,
        genero,
        preco,
        tipoTerror,
        nivelMedo,
        possuiJumpscares
    );

    jogos.Add(jogo);

    Console.WriteLine("Cadastrado com sucesso!!");

    Console.WriteLine("Deseja continuar com outro cadastro? s/n");
    continuar = Console.ReadLine();

    Console.WriteLine();
}

Console.WriteLine("===== LISTA DE JOGOS =====");

foreach (Jogo jogoCadastrado in jogos)
{
    jogoCadastrado.Apresentar();
    Console.WriteLine();
}

Console.WriteLine($"Total de jogos cadastrados: {jogos.Count}");