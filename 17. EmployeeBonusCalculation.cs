using System;
class Program 
{
  static void Main() 
  {
      Console.WriteLine("Enter the employee's years of service: ");
      int years = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter the employee's salary: ");
      double salary = Convert.ToDouble(Console.ReadLine ());
      
    if (years >= 5)
            {
                double bonus = salary * 0.10; 
                 Console.WriteLine("Bonus is $"+bonus);
            }
     
            else
            {
                double bonus = salary * 0.05;
                Console.WriteLine("Bonus is $" +bonus);
            }
    }
    
}
  