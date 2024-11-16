using System;

class Program
{
    static void Main()
    {
       
        Console.WriteLine("Enter your marks:");
        int marks = Convert.ToInt32(Console.ReadLine());
      
        string Grade;

        if (marks >= 90)
        {
            Grade = "A";
        }
        else if (marks >= 80)
        {
            Grade = "B";
        }
        else if (marks >= 70)
        {
            Grade = "C";
        }
        else if (marks >= 60)
        {
            Grade = "D";
        }
        else
        {
            Grade = "F";
        }

      
        Console.WriteLine("Your grade is: " + Grade);
    }
}