using System;
class Eligibility  
{
  static void Main() 
  {
      Console.WriteLine("Driving License Eligibility Checker");
      Console.WriteLine("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        
        if (age >= 18)
        {
            Console.WriteLine("Did you pass the driving test? (yes/no): ");
            string testresult = Console.ReadLine();
            
            if (testresult == "yes")
            {
                Console.WriteLine("Congratulations! You are eligible for a driving license.");
            }
            else if (testresult == "no") 
            {
                Console.WriteLine("You are not eligible for a driving license.");
            }
            else
            {
                Console.WriteLine("Invalid input for the test result.");
            }
        }
  }
}