// Arraylists

using System.Collections;
using System.Diagnostics;
using System.Globalization;

ArrayList arrayList = new ArrayList();

//Adicionando itens à lista

arrayList.Add(5);

//Adicionando quantias de itens à lista
arrayList.AddRange(new int [] { 1, 2, 3 });

//
arrayList.Insert(3, 7.8);

//Percorrendo itens da lista de forma genérica
foreach (object obj in arrayList)
{
    Console.WriteLine(obj);
}

// LISTAS GENÉRICAS

List<double> numbers = new List<double>();
Console.WriteLine("Digite 'sair' para encerrar.");

bool run = true;
do
{
    Console.WriteLine("Digite um número:");
    string numberStr = Console.ReadLine();

    if(numberStr.Equals("sair"))
    {
        run = false;
        Console.WriteLine("Processo encerrado.");
        break;
    }
    else
    {
        // Validação da entrada do usuário
        // para checar se é de fato um número
        if(!double.TryParse(
            numberStr, System.Globalization.NumberStyles.Float,
            new NumberFormatInfo(),
            out double number
            )
        )
        {
            Console.WriteLine("Você não digitou um número.");
            continue;
        }

        numbers.Add (number);
        Console.WriteLine("A média dos valores informados é: " 
        + numbers.Average()
        );
    }
} while(run);

// LISTAS DE TIPOS ABSTRATOS DE DADOS (TAD)

List<Person> people = new List<Person>();

// Criar uma variável do tipo Person

Person p1 = new Person();
p1.Name = "João";
p1.Age = 42;
p1.Nationality = CountryEnum.BR;

people.Add(p1);

// Adicionando à Lista inline

people.Add( new Person()
{
    Name = "Mary",
    Age = 39,
    Nationality = CountryEnum.US
});

people.Add( new Person()
{
    Name = "Carlitos",
    Age = 24,
    Nationality = CountryEnum.AR
});

people.Add( new Person()
{
    Name = "Juanito",
    Age = 34,
    Nationality = CountryEnum.PY
});

// Exemplo de ordenação de lista genérica
// Utilizando o LINQ

List<Person> results = 
people.OrderBy( p => p.Name).ToList();

// Percorremos a lista
foreach(Person p in results)
{
    Console.WriteLine(
        $"Nome: {p.Name}, Idade: {p.Age}, Nac: {p.Nationality}"
    );
}