using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of times to flip the coin: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int numberOfFlips) && numberOfFlips > 0)
        {
            int headsCount = 0;
            int tailsCount = 0;

            Random random = new Random();

            for (int i = 0; i < numberOfFlips; i++)
            {
                if (random.NextDouble() < 0.5)
                    tailsCount++;
                else
                    headsCount++;
            }

            double headsPercentage = (double)headsCount / numberOfFlips * 100;
            double tailsPercentage = (double)tailsCount / numberOfFlips * 100;

            Console.WriteLine($"Percentage of Heads: {headsPercentage}%");
            Console.WriteLine($"Percentage of Tails: {tailsPercentage}%");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
    }
}
