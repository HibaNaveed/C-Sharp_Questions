
using System;
class bmical {
  static void Main() {
      Console.WriteLine("Enter Your Height in Meter");
      double height= double.Parse(Console.ReadLine ());
        Console.WriteLine("Enter Your Weight in Kg");
      double weight= double.Parse(Console.ReadLine ());
      double bmi;
        // double bmi= double.Parse(Console.ReadLine ());
          bmi = weight / (height * height);
          Console.WriteLine("Your BMI is"+" " +bmi.ToString("F2"));
          
    if(bmi<18.5){
         Console.WriteLine("Underweight");
    }
    else if(bmi>=18.5 && bmi<=24.9){
         Console.WriteLine("Normal Weight");
    }
    else if(bmi>=25 && bmi<=29.9){
         Console.WriteLine("Over Weight");
    }
        else{
          Console.WriteLine("Obese");
        }
        
    }    
    }
    
  
