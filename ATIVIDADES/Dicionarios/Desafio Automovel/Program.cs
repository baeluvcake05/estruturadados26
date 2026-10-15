Dictionary<string, Automovel> automoveis = new Dictionary<string, Automovel>();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("======================================");
    Console.WriteLine("SISTEMA DE CONTROLE DE AUTOMÓVEIS");
    Console.WriteLine("======================================");
    Console.WriteLine("1 - Cadastrar automóvel");
    Console.WriteLine("2 - Buscar automóvel pela placa");
    Console.WriteLine("3 - Listar todos os automóveis");
    Console.WriteLine("4 - Buscar automóveis por marca");
    Console.WriteLine("5 - Sair");
    Console.WriteLine("======================================");

    Console.Write("Digite uma opção: ");
    string opcao = Console.ReadLine() ?? "";

    if (opcao == "1")
    {
        Console.Write("Digite a placa: ");
        string placa = (Console.ReadLine() ?? "").ToUpper();

        if (automoveis.ContainsKey(placa))
        {
            Console.WriteLine("Erro: já existe um automóvel cadastrado com essa placa.");
        }
        else
        {
            Console.Write("Digite a marca: ");
            string marca = Console.ReadLine() ?? "";

            Console.Write("Digite o modelo: ");
            string modelo = Console.ReadLine() ?? "";

            Console.Write("Digite o ano de fabricação: ");
            int ano = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite a cor: ");
            string cor = Console.ReadLine() ?? "";

            Console.Write("Digite o valor de venda: ");
            double valor = double.Parse(Console.ReadLine() ?? "0");

            automoveis.Add(placa, new Automovel()
            {
                Marca = marca,
                Modelo = modelo,
                Ano = ano,
                Cor = cor,
                Valor = valor
            });

            Console.WriteLine("Automóvel cadastrado com sucesso!");
        }
    }
    else if (opcao == "2")
    {
        Console.Write("Digite a placa para buscar: ");
        string placa = (Console.ReadLine() ?? "").ToUpper();

        if (automoveis.TryGetValue(placa, out Automovel? automovel))
        {
            Console.WriteLine();
            Console.WriteLine("--- AUTOMÓVEL ENCONTRADO ---");
            Console.WriteLine("Placa: " + placa);
            Console.WriteLine("Marca: " + automovel.Marca);
            Console.WriteLine("Modelo: " + automovel.Modelo);
            Console.WriteLine("Ano: " + automovel.Ano);
            Console.WriteLine("Cor: " + automovel.Cor);
            Console.WriteLine("Valor: R$ " + automovel.Valor.ToString("F2"));
        }
        else
        {
            Console.WriteLine("Automóvel não encontrado.");
        }
    }
    else if (opcao == "3")
    {
        if (automoveis.Count == 0)
        {
            Console.WriteLine("Nenhum automóvel cadastrado.");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("--- TODOS OS AUTOMÓVEIS ---");

            foreach (var item in automoveis)
            {
                Console.WriteLine();
                Console.WriteLine("Placa: " + item.Key);
                Console.WriteLine("Marca: " + item.Value.Marca);
                Console.WriteLine("Modelo: " + item.Value.Modelo);
                Console.WriteLine("Ano: " + item.Value.Ano);
                Console.WriteLine("Cor: " + item.Value.Cor);
                Console.WriteLine("Valor: R$ " + item.Value.Valor.ToString("F2"));
            }
        }
    }
    else if (opcao == "4")
    {
        Console.Write("Digite a marca que deseja buscar: ");
        string marcaBusca = Console.ReadLine() ?? "";

        bool encontrado = false;

        foreach (var item in automoveis)
        {
            if (item.Value.Marca.Equals(
                marcaBusca,
                StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine();
                Console.WriteLine("--- AUTOMÓVEL ENCONTRADO ---");
                Console.WriteLine("Placa: " + item.Key);
                Console.WriteLine("Marca: " + item.Value.Marca);
                Console.WriteLine("Modelo: " + item.Value.Modelo);
                Console.WriteLine("Ano: " + item.Value.Ano);
                Console.WriteLine("Cor: " + item.Value.Cor);
                Console.WriteLine("Valor: R$ " + item.Value.Valor.ToString("F2"));

                encontrado = true;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Nenhum automóvel encontrado para essa marca.");
        }
    }
    else if (opcao == "5")
    {
        Console.WriteLine("Sistema encerrado.");
        break;
    }
    else
    {
        Console.WriteLine("Opção inválida. Digite uma opção de 1 a 5.");
    }
}

public class Automovel
{
    public string Marca { get; set; } = "";
    public string Modelo { get; set; } = "";
    public int Ano { get; set; }
    public string Cor { get; set; } = "";
    public double Valor { get; set; }
}