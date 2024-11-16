using System;

class integer
{
    static void Main()
    {
        Console.WriteLine("Enter an integer:");
    
        int number = Convert.ToInt32(Console.ReadLine());
        
        if (number % 2 == 0)
        {
            Console.WriteLine("This is an even number.");
        }
        else
        {
            Console.WriteLine("This is an odd number.");
        }
    }
}
