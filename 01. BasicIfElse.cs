using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an integer");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine("This number is positive");
        }
        else if (number < 0)
        {
            Console.WriteLine("This number is negative");
        }
        else
        {
            Console.WriteLine("This number is zero");
        }
    }
}