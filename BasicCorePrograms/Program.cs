using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsEven(number))
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is odd.");
        }
    }

    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
}
