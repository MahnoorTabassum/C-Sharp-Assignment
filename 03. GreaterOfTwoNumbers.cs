using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

          if (num1 > num2)
        {
            Console.WriteLine("The greater number is " + num1);
        }
        else if (num2 > num1)
        {
            Console.WriteLine("The greater number is " + num2);
        }
         else
        {
            Console.WriteLine("Both numbers are equal");
        }
    }
}