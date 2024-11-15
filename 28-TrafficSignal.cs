using System;

class TrafficLightInstructions
{
    static void Main()
    {
       
        Console.WriteLine("Enter the traffic light color (Red, Yellow, Green):");
        string color = Console.ReadLine().ToLower();
        

        switch (color)
        {
            case "red":
                Console.WriteLine("STOP! Wait for the green light.");
                break;
            case "yellow":
                Console.WriteLine("CAUTION! Prepare to stop.");
                break;
            case "green":
                Console.WriteLine("GO! You may proceed.");
                break;
            default:
                Console.WriteLine("Please enter Red, Yellow, or Green.");
                break;
        }
    }
}
