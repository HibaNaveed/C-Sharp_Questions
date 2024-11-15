using System;

class BMICalculator
{
    static void Main()
    {
        Console.WriteLine("Enter your weight in Kg");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter your height in Meter");
        double height = Convert.ToDouble(Console.ReadLine());

        double bmi = weight / (height * height);

        Console.WriteLine("BMI is:"+bmi);

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
