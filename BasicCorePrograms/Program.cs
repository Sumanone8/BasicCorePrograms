using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 1)
        {
            int number = Convert.ToInt32(args[0]);

            if (number > 0)
            {
                Console.Write($"Prime factors of {number}: ");
                PrintPrimeFactors(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Number should be a positive integer.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please provide a single command-line argument.");
        }
    }

    static void PrintPrimeFactors(int number)
    {
        for (int i = 2; i * i <= number; i++)
        {
            while (number % i == 0)
            {
                Console.Write($"{i} ");
                number /= i;
            }
        }

        if (number > 1)
        {
            Console.Write($"{number} ");
        }

        Console.WriteLine();
    }
}

