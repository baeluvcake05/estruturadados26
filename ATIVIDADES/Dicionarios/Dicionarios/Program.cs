using System.Collections;
using System.Runtime.Intrinsics.Arm;

Hashtable phoneBook = new Hashtable()
{
    { "Edson Arantes do Nascimento", "0000" }, 
    { "Ronaldo Nazáreo dos Santos", "1111" },
    { "Luiz Inácio Lula da Silva", "2222" }
};

// Adicionando em Tempo de execução

phoneBook["Acelino Popó de Freitas"] = "3333";

// Tratando possível erro de duplicidade de chave

try
{
    phoneBook.Add("Edson Arantes do Nascimento", "000000");
}
catch (System.ArgumentException ae) {
    Console.WriteLine("Chave já existente. " + ae.Message);
}
catch (System.Exception ex)
{
    Console.WriteLine("Erro Imprevisto. " + ex.Message);
}

//Percorrendo valores TabelaHash

Console.WriteLine ("Caderninho de telefone: ");
if(phoneBook.Count == 0)
{
    Console.WriteLine("Agenda Vazia!");
}
else
{
    int i = 1;
    foreach(DictionaryEntry entry in phoneBook)
    {
        Console.WriteLine($"{i}. {entry.Key} - {entry.Value}");
        i++;
    }
}

//Busca em chaves

Console.WriteLine ("");
Console.WriteLine("Busca por Nome: ");
string name = Console.ReadLine();

if(phoneBook.Contains (name))
{
    string number = (string)phoneBook[name];
    Console.WriteLine (name + " - " + number);
}
else
{
    Console.WriteLine($"{name} não encontrado.");
}

/*
    DICIONÁRIOS
*/

Dictionary<string, string> dic = 
new Dictionary<string, string> ()
{
    {"Dom Pedrão II", "123456"},
    {"Joaquim José da Silva Xavier", "112233"}
};

// Obtendo valor do dicionário
string value = dic["Dom Pedrão II"]; 

dic["Dom Pedrão II"] = "666";

foreach(KeyValuePair<string, string> pair in dic)
{
    Console.WriteLine ("" + pair.Key + " " + pair.Value);
}