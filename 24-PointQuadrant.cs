using System;

class Quadrant
{
    static void Main()
    {

        Console.WriteLine("Enter the x-coordinate ");
        double x = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter the y-coordinate ");
        double y = Convert.ToDouble(Console.ReadLine());

        if (x == 0 && y == 0)
        {
            Console.WriteLine("The point is at the Origin.");
        }
        else if (x == 0)
        {
            Console.WriteLine("The point is on the Y-axis.");
        }
        else if (y == 0)
        {
            Console.WriteLine("The point is on the X-axis.");
        }
        else if (x > 0 && y > 0)
        {
            Console.WriteLine("The point is in Quadrant I.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("The point is in Quadrant II.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("The point is in Quadrant III.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("The point is in Quadrant IV.");
        }
    }
}
