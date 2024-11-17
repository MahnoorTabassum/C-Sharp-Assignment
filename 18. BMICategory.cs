using System;

class Program 
{
  static void Main() 
  {
      Console.WriteLine("Enter your weight in kilograms");
        double weight = Convert.ToSingle(Console.ReadLine());

      Console.WriteLine("Enter your height in meters");
        double height = Convert.ToSingle(Console.ReadLine());
        
         double bmi = weight / (height * height);
         Console.WriteLine("Your BMI is " +bmi);
          
            if (bmi < 18.5){
                Console.WriteLine("Underweight");
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                Console.WriteLine("Normal");
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                Console.WriteLine("Overweight");
            }
            else
            {
                Console.WriteLine("Obese");
            }

    }
}