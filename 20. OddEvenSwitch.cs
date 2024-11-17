using System;
class program
{
  static void Main() 
  {
       Console.WriteLine("Enter a Number");
      int integer = Convert.ToInt32(Console.ReadLine());
      switch(integer % 2) 
{
  case 0:
        Console.WriteLine(integer+" "+"is even");
    break;
    case 1:
        Console.WriteLine(integer+" "+"is Odd");
    break;
    
  default:
    Console.WriteLine("Invalid Number");
    break;
}
  }
}