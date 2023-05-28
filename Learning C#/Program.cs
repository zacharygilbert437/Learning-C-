ConvertToPascalCase();

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
/* Prompt:
 * Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. 
 * For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
*/
static void IsConsecutive()
{
    bool needInput = true;
    string[] input = { };
    while (needInput)
    {
        needInput = false;
        Console.Write("Enter any number of non-negative integers separated by a hyphen: ");
        input = Console.ReadLine().Split('-');
        foreach(string s in input)
        {
            try
            {
                int.Parse(s);
            }
            catch
            {
                Console.WriteLine($"{s} is not an integer. Please try again.");
                needInput = true;
            }
        }
    }
    int[] nums = input.Select(x=>int.Parse(x)).ToArray();
    int consecutiveDirection = nums[0] > nums[1] ? -1 : 1;
    bool isConsecutive = true;
    for (int i = 0;i < nums.Length - 1;i++)
        if (nums[i] + consecutiveDirection != nums[i + 1])
            isConsecutive = false;
    string output = isConsecutive ? "Conseuctive" : "Not consecutive";
    Console.WriteLine(output);
}

/* Prompt:
 * Write a program and ask the user to enter a few numbers separated by a hyphen. 
 * If the user simply presses Enter, without supplying an input, exit immediately; 
 * otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console. 
*/
static void CheckForDuplicates()
{
    bool needInput = true;
    string[] numsAsStrings = { };
    while (needInput)
    {
        needInput = false;
        Console.Write("Enter any number of non-negative integers separated by a hyphen: ");
        string input = Console.ReadLine();
        if (String.IsNullOrEmpty(input))
            Environment.Exit(0);
        
        numsAsStrings = input.Split('-');
        foreach (string s in numsAsStrings)
        {
            try
            {
                int.Parse(s);
            }
            catch
            {
                Console.WriteLine($"{s} is not an integer. Please try again.");
                needInput = true;
            }
        }
    }
    IEnumerable<int> nums = numsAsStrings.Select(x => int.Parse(x));
    string output = nums.ToArray().Length == nums.Distinct().ToArray().Length ? "": "Duplicate"; 
    Console.WriteLine(output);
}

/* Prompt:
 * Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
 * A valid time should be between 00:00 and 23:59. 
 * If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
 * If the user doesn't provide any values, consider it as invalid time. 
*/

static void CheckTime()
{
    bool validTime = false;
    while (!validTime)
    {
        Console.Write("Please enter a time in the format HH:mm: ");
        string input = Console.ReadLine();
        string[] times = input.Split(':');
        try
        {
            int hours = int.Parse(times[0]);
            int minutes = int.Parse(times[1]);

            bool validMinuteFormat = times[1].Length == 2;
            bool valid24HourTime = hours >=0 && minutes >=0 && hours < 24 && minutes < 60;

            if (validMinuteFormat && valid24HourTime)
            {
                Console.WriteLine("Ok");
                validTime = true;
            }
            else
                Console.WriteLine($"{input} is not a valid time. Please try again");
        }
        catch
        {
            Console.WriteLine($"{input} is not a valid time. Please try again");
        }
            
    }

}


static void ConvertToPascalCase()
{
    Console.Write("Enter some words separated by a space: ");
    string[] input = Console.ReadLine().Split();
    IEnumerable<String> words = input.Select(x => Char.ToUpper(x[0]) + x.Substring(1).ToLower());
    Console.WriteLine(String.Join("", words));
}

