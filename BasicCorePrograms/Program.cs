using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the dividend: ");
        int dividend = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the divisor: ");
        int divisor = Convert.ToInt32(Console.ReadLine());

        int quotient = dividend / divisor;
        int remainder = dividend % divisor;

        Console.WriteLine($"Quotient: {quotient}");
        Console.WriteLine($"Remainder: {remainder}");
    }
}