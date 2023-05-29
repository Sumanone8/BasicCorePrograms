using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter an alphabet: ");
        char alphabet = Convert.ToChar(Console.ReadLine());

        if (IsVowel(alphabet))
        {
            Console.WriteLine("The alphabet is a vowel.");
        }
        else
        {
            Console.WriteLine("The alphabet is a consonant.");
        }
    }

    static bool IsVowel(char alphabet)
    {
        // Convert the alphabet to lowercase for case-insensitive comparison
        alphabet = Char.ToLower(alphabet);

        // Check if the alphabet is a vowel
        return alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u';
    }
}
