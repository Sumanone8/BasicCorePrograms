using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 1)
        {
            int n = Convert.ToInt32(args[0]);

            if (n >= 0 && n < 31)
            {
                PrintPowersOfTwo(n);
            }
            else
            {
                Console.WriteLine("Invalid input. Please provide a single command-line argument (0 <= N < 31).");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please provide a single command-line argument (0 <= N < 31).");
        }
    }

    static void PrintPowersOfTwo(int n)
    {
        for (int i = 0; i <= n; i++)
        {
            int powerOfTwo = Convert.ToInt32(Math.Pow(2, i));
            Console.WriteLine($"2^{i} = {powerOfTwo}");
        }
    }
}
