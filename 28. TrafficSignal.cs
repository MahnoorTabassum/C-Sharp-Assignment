using System;
class TrafficLight
{
  static void Main()
  {
        Console.WriteLine("Enter the color of the traffic light (Red, Yellow, Green): ");
        string lightColor = Console.ReadLine(); 

        switch (lightColor)
        {
            case "red":
                Console.WriteLine("STOP! Wait until the light turns green.");
                break;

            case "yellow":
                Console.WriteLine("READY! Prepare to move, but do not go yet.");
                break;

            case "green":
                Console.WriteLine("GO! Now You can proceed safely.");
                break;

            default:
                Console.WriteLine("Invalid input! Please enter Red, Yellow, or Green.");
                break;
        }
    }
}