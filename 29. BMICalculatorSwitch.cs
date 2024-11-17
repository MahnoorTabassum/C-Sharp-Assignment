using System;

class Program 
{
  static void Main() 
  {
      Console.WriteLine("BMI Calculator");
      
      Console.WriteLine("Enter your weight in kilograms");
        double weight = Convert.ToSingle(Console.ReadLine());

      Console.WriteLine("Enter your height in meters");
        double height = Convert.ToSingle(Console.ReadLine());
        
      double bmi = weight / (height * height);

        Console.WriteLine("BMI is:"+ bmi);

        int bmiCategory = (int)(bmi / 5);  
        
        switch (bmiCategory)
        {
            case 0:
            case 1:
                Console.WriteLine("Underweight");
                break;
            case 2:
            case 3:
                Console.WriteLine("Normal");
                break;
            case 4:
            case 5:
                Console.WriteLine("Overweight");
                break;
            case 6:
            case 7:
                Console.WriteLine("Obese");
                break;
            default:
                Console.WriteLine("Invalid BMI category.");
                break;
        }
    }
}
         
         