using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int num = Convert.ToInt32(Console.ReadLine());

        if ( num > 0 && num % 2 == 0 )
            {
                Console.WriteLine("The number is positive and even.");
            }
        else if(num > 0 && num % 2 != 0)
            {
                Console.WriteLine("The number is positive and odd");
            }
        else if (num < 0 && num % 2 == 0)
            {
                Console.WriteLine("The number is negative and Even");
            }
        else if (num < 0 && num % 2 != 0)
            {
                Console.WriteLine("The number is negative and odd");
            }
        else
        {
            Console.WriteLine("The number is zero.");
        }
    }
}