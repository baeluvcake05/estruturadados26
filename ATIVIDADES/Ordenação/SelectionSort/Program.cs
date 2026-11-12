int [] integerValues = { -11, 12, -42, 0, 1, 90, 6, -9};


    Console.WriteLine("Vetor Original");

    Console.WriteLine(string.Join(", ", integerValues));

SelectionSort.SelecionSort.Sort(integerValues);

    Console.WriteLine("Vetor Ordenado");

    Console.WriteLine(string.Join(",", integerValues));


    string [] stringValues = { "Chernobyl", "Eudes", "Mayckon", "Fernandes", 
    "Serjão", "Gorgulho", "Matheus", "Christhyan"};


    Console.WriteLine("Vetor Original");

    Console.WriteLine(string.Join(", ", stringValues));

SelectionSort.SelecionSort.Sort(stringValues);

    Console.WriteLine("Vetor Ordenado");

    Console.WriteLine(string.Join(", ", stringValues));

