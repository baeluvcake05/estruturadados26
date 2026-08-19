using System.Linq;
string word;
int wordNumber;

Console.WriteLine("Digite uma palavra: ");
word = new string(Console.ReadLine());
char[] palindromo = word.ToCharArray();
char[] maybePalindromo = word.ToCharArray();

for(int i = 0; i < palindromo.Length; i++)
{
    wordNumber = palindromo.Length - 1;
    maybePalindromo[i] = palindromo[wordNumber - i];
}

bool itsEqual = palindromo.SequenceEqual(maybePalindromo);

if(itsEqual == true)
{
    Console.WriteLine("Está palavra é um palindromo");
}

else
{
    Console.WriteLine("Está palavra não é um palindromo");
}