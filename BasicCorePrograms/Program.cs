using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int largest = FindLargest(num1, num2, num3);

        Console.WriteLine($"The largest number among {num1}, {num2}, and {num3} is: {largest}");
    }

    static int FindLargest(int num1, int num2, int num3)
    {
        int largest = num1;

        if (num2 > largest)
        {
            largest = num2;
        }

        if (num3 > largest)
        {
            largest = num3;
        }

        return largest;
    }
}
