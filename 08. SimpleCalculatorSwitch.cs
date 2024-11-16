using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Calculator");
        Console.WriteLine("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

       
        Console.WriteLine("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

      
        Console.WriteLine("Enter an operator (+, -, *, /): ");
        char operation = Convert.ToChar(Console.ReadLine());

        
        switch (operation)
        {
            case '+':
                Console.WriteLine("Result: " + (num1 + num2));
                break;

            case '-':
                Console.WriteLine("Result: " + (num1 - num2));
                break;

            case '*':
                Console.WriteLine("Result: " + (num1 * num2));
                break;

            case '/':
                {
                    Console.WriteLine("Result: " + (num1 / num2));
                }
               break;

           
        }
    }
}