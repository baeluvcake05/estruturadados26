int [] integerValues = { -11, 12, -42, 0, 1, 90, 6, -9};


    Console.WriteLine("Vetor Original");

    Console.WriteLine(string.Join(", ", integerValues));

InsertionSort.InsertionSort.Sort(integerValues);

    Console.WriteLine("Vetor Ordenado");

    Console.WriteLine(string.Join(",", integerValues));


    string [] stringValues = { "Chernobyl", "Eudes", "Mayckon", "Fernandes", 
    "Serjão", "Gorgulho", "Matheus", "Christhyan"};


    Console.WriteLine("Vetor Original");

    Console.WriteLine(string.Join(", ", stringValues));

InsertionSort.InsertionSort.Sort<string>(stringValues);

    Console.WriteLine("Vetor Ordenado");

    Console.WriteLine(string.Join(", ", stringValues));

    Console.WriteLine($"Total de Operações: {InsertionSort.InsertionSort.OperationCount}");


