using System;

class Quadrant
{
    static void Main()
    {

        Console.WriteLine("Enter the x-coordinate ");
        double x = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter the y-coordinate ");
        double y = Convert.ToDouble(Console.ReadLine());

        if (y == 0 && x != 0)
            {
                Console.WriteLine("The point is on the X-axis.");
            }
        else if (x == 0 && y != 0)
            {
                Console.WriteLine("The point is on the Y-axis.");
            }    
        else if (x > 0 && y > 0)
        {
            Console.WriteLine("The point is in 1 Quadrant.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("The point is in 2 Quadrant.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("The point is in 3 Quadrant.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("The point is in 4 Quadrant.");
        }    
        else
            {
                Console.WriteLine("The point is at the origin.");
            }
    }
}