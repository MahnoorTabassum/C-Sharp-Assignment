using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of terms for the Fibonacci series: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int a = 0, b = 1;

        Console.WriteLine("Fibonacci Series:");
        for (int i = 0; i < num; i++)
        {
            Console.Write(a + " ");
            int c = a + b;
            a = b;
            b = c;
        }
    }
}
