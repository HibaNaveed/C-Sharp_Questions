
using System;
class bonuscal {
  static void Main() {
      Console.WriteLine("Enter Your Years");
      int year= Convert.ToInt32(Console.ReadLine ());
        Console.WriteLine("Enter Your Salary");
      double sal= Convert.ToDouble(Console.ReadLine ());
      
    if(year>=5){
        double bonus=sal*0.10;
         Console.WriteLine("Bonus is"+"" +bonus);
    }
    else if(year<5 && year>1){
        double bonus=sal*0.05;
         Console.WriteLine("Bonus is"+"" +bonus);
    }
        else{
          Console.WriteLine("You are not eligible for bonus this year");
        }
        
    }    
    }
    
  
