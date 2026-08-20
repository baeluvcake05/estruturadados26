// Arraylists

using System.Collections;

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
    Console.WriteLine (obj);
}