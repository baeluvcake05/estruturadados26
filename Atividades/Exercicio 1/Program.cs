int[] numbers;
numbers = new int[10];
int[] evenNumbers;
int[] oddNumbers;
int totalEven = 0;
int totalOdd = 0;

for(int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite para [" + i + "]: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

for(int i = 0; i < 10; i++)
{
    if(numbers[i] % 2 == 0)
    {
        totalEven++;
    }
    else
    {
        totalOdd++;
    }
}

evenNumbers = new int[totalEven];
oddNumbers = new int[totalOdd];

totalEven = 0;
totalOdd = 0;

for(int i = 0; i < 10; i++)
{
    if(numbers[i] % 2 == 0)
    {
        evenNumbers[totalEven] = numbers[i];
        totalEven++;
    }
    else
    {
        oddNumbers[totalOdd] = numbers[i];
        totalOdd++;
    }
}

Console.WriteLine("Par: ");
for(int i = 0; i < totalEven; i++)
{
    Console.WriteLine(evenNumbers[i]);
}

Console.WriteLine("Impar: ");
for(int i = 0; i < totalOdd; i++)
{
    Console.WriteLine(oddNumbers[i]);
}