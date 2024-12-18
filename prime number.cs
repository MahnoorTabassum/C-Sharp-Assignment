using System;
class PrimeNum {
  static void Main()
  {
         Console.Write("Enter a number to check if it's prime: ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool Prime = true;
            
            for (int i = 2; i < number/2; i++)
            {
                if (number % i == 0)
                {
                    Prime = false;
                    break;
                }
            }
            if (Prime)
            {
                Console.Write(number+ " Number is Prime.");
            }
            else
            {
                Console.Write(number+ " Number is not Prime.");
            }
        }
    }
