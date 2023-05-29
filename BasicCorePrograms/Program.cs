using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Before swapping: num1 = {num1}, num2 = {num2}");

        // Swapping logic using a temporary variable
        int temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine($"After swapping: num1 = {num1}, num2 = {num2}");
    }
}
