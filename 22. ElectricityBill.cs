using System;
class electricity 
{
  static void Main()
  {
   Console.Write("Enter number of units consumed: ");
        double units = Convert.ToDouble(Console.ReadLine());
        
         double billAmount;
         
         if (units <= 50)
        {
            billAmount = units * 1.5; 
        }
        else if (units <= 150)
        {
            billAmount = (50 * 1.5) + ((units - 50) * 2.5); 
        }
        else if (units <= 250)
        {
            billAmount = (50 * 1.5) + (100 * 2.5) + ((units - 150) * 4.0); 
        }
        else
        {
            billAmount = (50 * 1.5) + (100 * 2.5) + (100 * 4.0) + ((units - 250) * 5.0); 
        }

        Console.WriteLine("The total electricity bill is: "+  billAmount + " units");
    }
}