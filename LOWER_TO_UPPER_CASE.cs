using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("How many Alphabets do you want to convert?");
        int count = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <=count; i++)
        {
            Console.WriteLine("Write any Alphabet in lowercase:");
            string input = Console.ReadLine(); 
            string convert = input.ToUpper(); 
            Console.WriteLine("Converted to Uppercase: " + convert);
        }
    }
}
