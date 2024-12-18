using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your birth year: ");
        int birthYear = Convert.ToInt32(Console.ReadLine());

        int currentYear = DateTime.Now.Year;

        for (int year = birthYear; year <= currentYear; year++)
        {
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine(year);
            }
        }
    }
}
