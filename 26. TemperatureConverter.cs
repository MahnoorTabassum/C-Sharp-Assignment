using System;

class TemperatureConverter
{
    static void Main()
    {
        Console.WriteLine("Temperature  Converter");
        Console.WriteLine("Select an Option:");
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Celsius to Kelvin");
        Console.WriteLine("3. Fahrenheit to Celsius");
        Console.WriteLine("4. Fahrenheit to Kelvin");
        Console.WriteLine("5. Kelvin to Celsius");
        Console.WriteLine("6. Kelvin to Fahrenheit");
        
         Console.Write("Select an option (1-6): ");
        int select = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter the temperature to convert: ");
        int output = Convert.ToInt32(Console.ReadLine());

        int result;

        switch (select)
        {
            case 1:
                result = (output * 9 / 5) + 32;
                Console.WriteLine(output + " Celsius = " + result + " Fahrenheit");
                break;

            case 2:
                result = output + 273;
                Console.WriteLine(output + " Celsius = " + result + " Kelvin");
                break;

            case 3:
                result = (output - 32) * 5 / 9;
                Console.WriteLine(output + " Fahrenheit = " + result + " Celsius");
                break;

            case 4:
                result = (output - 32) * 5 / 9 + 273;
                Console.WriteLine(output + " Fahrenheit = " + result + " Kelvin");
                break;

            case 5:
                result = output - 273;
                Console.WriteLine(output + " Kelvin = " + result + " Celsius");
                break;

            case 6:
                result = (output - 273) * 9 / 5 + 32;
                Console.WriteLine(output + " Kelvin = " + result + " Fahrenheit");
                break;

           default:
                Console.WriteLine("Invalid choice! Please enter a number between 1 and 6.");
                break;
           
        }
    }
}