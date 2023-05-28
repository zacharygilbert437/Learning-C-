

using System.ComponentModel;

GuessingGame();

static void CountDivBy3()
{
    int count = 0;
    for(int i=1;i<100;i++)
        if(i % 3 == 0) count++;
    Console.WriteLine($"{count} numbers are divisible by 3 between 1 and 100");
}


static void SumOfNumbers()
{
    int sum = 0;
    while (true)
    {
        Console.Write("Input a number or type \"ok\" to quit: ");
        string input = Console.ReadLine();
        if (input == "ok")
            break;
        try
        {
            sum += int.Parse(input); 
        }
        catch
        {
            Console.WriteLine("Invalid input");
        }
    }
    Console.WriteLine($"Sum of entered numbers: {sum}");
}

static void ComputeFactorial()
{
    int baseNum;
    Console.Write($"Enter number for factorial calculation: ");
    do
    {
        string input = Console.ReadLine();
        try
        {
            baseNum = int.Parse(input);
            if (baseNum < 0)
                throw new Exception();
            break;
        }
        catch
        {
            Console.WriteLine($"{input} is not a valid input. Please input a non-negative integer");
        }

    } while (true);
    int prod = 1;
    for (int i = 1; i <= baseNum; i++)
        prod *= i;
    Console.WriteLine($"{baseNum}! = {prod}");
}

static void GuessingGame()
{
    Random random = new Random();
    int magicNumber = random.Next(1,11);
    int guesses = 0;
    while (guesses < 4)
    {
        Console.Write("Guess a number between 1 and 10 (inclusive): ");
        string input = Console.ReadLine();
        int currGuess;
        try
        {
            currGuess = int.Parse(input);
        }
        catch
        {
            Console.WriteLine("Invalid input");
            continue;
        }
        if(currGuess == magicNumber)
        {
            Console.WriteLine("You guessed it! You win!");
            return;
        }
        else
        {
            guesses++;
        }

    }
    Console.WriteLine("You lose.");
}

static void FindMaximum()
{
    return;
} 


static void IsConsecutive()
{
    Console.Write("Enter any number of integers separated by a hyphen: ");
    string input = Console.ReadLine() ;
}