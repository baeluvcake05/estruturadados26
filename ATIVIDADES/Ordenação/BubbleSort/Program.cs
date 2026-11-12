int [] integerValues = { -11, 12, -42, 0, 1, 90, 6, -9};


    Console.WriteLine("Vetor Original");

    Console.WriteLine(string.Join(", ", integerValues));

BubbleSort.BubbleSort.Sort(integerValues);

    Console.WriteLine("Vetor Ordenado");

    Console.WriteLine(string.Join(",", integerValues));


    string [] stringValues = { "Chernobyl", "Eudes", "Mayckon", "Fernandes", 
    "Serjão", "Gorgulho", "Matheus", "Christhyan"};


    Console.WriteLine("Vetor Original");

    Console.WriteLine(string.Join(", ", stringValues));

BubbleSort.BubbleSort.Sort(stringValues);

    Console.WriteLine("Vetor Ordenado");

    Console.WriteLine(string.Join(", ", stringValues));

    Console.WriteLine($"Total de Operações: {BubbleSort.BubbleSort.OperationCount}");
    Console.WriteLine($"Total de Trocas: {BubbleSort.BubbleSort.SwapCount}");
