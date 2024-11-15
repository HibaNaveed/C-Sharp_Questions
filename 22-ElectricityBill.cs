
using System;
class electricity {
  static void Main() {
   Console.Write("Enter number of units consumed: ");
        double units = Convert.ToDouble(Console.ReadLine());
        double bill=0.0;
        
        if (units <= 50)
        {
            bill = units * 3.95;
        }
        else if (units <= 150)
        {
            bill = (50 * 3.95) + ((units - 50) * 7.74);
        }
        else if (units <= 250)
        {
            bill = (50 * 3.95) + (100 * 7.74) + ((units - 150) * 10);
        }
        else
        {
            Console.WriteLine("You have consumed above 250 Units");
        }
        Console.WriteLine("Total electricity bill"+" " + units + " " + bill);
    }
}