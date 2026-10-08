Dictionary<string, string> products =
    new Dictionary<string, string>
{
    { "5900000000000", "A1" },
    { "5901111111111", "B5" },
    { "5902222222222", "C9" }
};
products["5903333333333"] = "D7";

try
{
    products.Add("5904444444444", "A3");
}
catch (ArgumentException)
{
    Console.WriteLine("A entrada já existe.");
}

Console.WriteLine("Todos os produtos:");
if (products.Count == 0)
{
    Console.WriteLine("Vazio.");
}
else
{
    foreach (KeyValuePair<string, string> product in products)
    {
        Console.WriteLine($" - {product.Key}: {product.Value}");
    }
}

Console.WriteLine();

Console.Write("Procurar por código: ");
string barcode = Console.ReadLine();

if (products.TryGetValue(barcode, out string location))
{
    Console.WriteLine($"O produto está na área {location}.");
}
else
{
    Console.WriteLine("Esse produto não existe.");
}