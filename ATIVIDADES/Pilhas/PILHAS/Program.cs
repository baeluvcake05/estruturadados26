using System.Collections.Generic;

Stack<char> chars = new Stack<char>();

string text = string.Empty;
Console.WriteLine("Digite uma palavra:");
text = Console.ReadLine();

string reversedText = string.Empty;
foreach (char c in text) {
    chars.Push(c);
}

while (chars.Count > 0)
{
        reversedText += chars.Pop();
}

Console.WriteLine(reversedText);

string isPalindromo = 
text == reversedText 
? "É Palíndrimo" 
: "NÃO é palíndromo";


Console.WriteLine(isPalindromo);
Console.WriteLine("");
