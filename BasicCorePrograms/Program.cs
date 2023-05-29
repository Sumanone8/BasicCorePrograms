using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int year) && IsFourDigitNumber(year))
        {
            if (IsLeapYear(year))
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid 4-digit year.");
        }
    }

    static bool IsFourDigitNumber(int year)
    {
        return year >= 1000 && year <= 9999;
    }

    static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}
