using System;

class PalindromeChecker
{
    static void Main()
    {
        Console.WriteLine("Enter a word or number: ");
        string input = Console.ReadLine();
        
        string reversed = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }

        if (input == reversed)
        {
            Console.WriteLine( input + " is a palindrome.");
        }
        else
        {
            Console.WriteLine(input + " is not a palindrome.");
        }
    }
}
