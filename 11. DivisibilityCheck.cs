using System;

class DivisibleCheck
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 5 == 0)
        {
            Console.WriteLine(number + " number is divisible by 5.");
        }
        else if (number % 11 == 0)
        {
            Console.WriteLine(number + " number is divisible by 11.");
        }
         else{
         Console.WriteLine(number + " number is not divisible by 5 or 11");
    }
    }
}