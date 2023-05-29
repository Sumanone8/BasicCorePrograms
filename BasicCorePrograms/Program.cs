using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 1)
        {
            int n = Convert.ToInt32(args[0]);

            if (n != 0)
            {
                double harmonicNumber = ComputeHarmonicNumber(n);
                Console.WriteLine($"The {n}th Harmonic Value: {harmonicNumber}");
            }
            else
            {
                Console.WriteLine("Invalid input. N should be a non-zero value.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please provide a single command-line argument.");
        }
    }

    static double ComputeHarmonicNumber(int n)
    {
        double harmonicSum = 0;

        for (int i = 1; i <= n; i++)
        {
            harmonicSum += 1.0 / i;
        }

        return harmonicSum;
    }
}

