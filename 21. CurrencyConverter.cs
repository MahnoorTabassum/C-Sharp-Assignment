using System;

class CurrencyConverter
{
    static void Main()
    {
        double amount, result;
        int currency;

        Console.WriteLine("Currency Converter");
        Console.WriteLine("1. Pkr Rupees to Dollar");
        Console.WriteLine("2. Pkr Rupees to Euro");
        Console.WriteLine("3. Pkr Rupees to Pound");

        Console.Write("Enter your choice (1/2/3): ");
        currency = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the amount in PKR to convert: ");
        amount = Convert.ToDouble(Console.ReadLine()); 

        switch (currency)
        {
            case 1:
                result = amount / 278.49; 
                Console.WriteLine($"{amount} Pkr Rupees equals {result:F2} Dollar(s)");
                break;

            case 2:
                result = amount / 293.68; 
                Console.WriteLine($"{amount} Pkr Rupees equals {result:F2} Euro(s)");
                break;

            case 3:
                result = amount / 350.67; 
                Console.WriteLine($"{amount} Pkr Rupees equals {result:F2} Pound(s)");
                break;

            default:
                Console.WriteLine("Invalid choice! Please enter 1, 2, or 3.");
                break;
        }

    }
}
