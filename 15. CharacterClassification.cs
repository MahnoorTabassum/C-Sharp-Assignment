using System;
class Program {
  static void Main() 
  {
       Console.WriteLine("Enter any character");
        char Character = Convert.ToChar(Console.ReadLine());

        if (char.IsUpper(Character))
        {
            Console.WriteLine("The character is in Uppercase.");
        }
        else if (char.IsLower(Character))
        {
            Console.WriteLine("The character is in Lowercase.");
        }
        else if (char.IsDigit(Character))
        {
            Console.WriteLine("The character is a Digit.");
        }
        else
        {
            Console.WriteLine("The character is a special character.");
        }
  }
}