
using System;
class largestnumber {
  static void Main() {
      Console.WriteLine("Enter First Number");
      int num1=Convert.ToInt32(Console.ReadLine ());
      
           Console.WriteLine("Enter Second Number");
      int num2=Convert.ToInt32(Console.ReadLine ());
      
           Console.WriteLine("Enter Third Number");
      int num3=Convert.ToInt32(Console.ReadLine ());
    if(num1>=num2){
        if(num1>=num3){
             Console.WriteLine("The Largest number is"+" "+num1);
        }
        else{
          Console.WriteLine("The Largest number is"+" "+num3);
        }
        }
    else{
        if(num2>=num3){
             Console.WriteLine("The Largest number is"+" "+num2);
        }
        else{
          Console.WriteLine("The Largest number is"+" "+num3);
        }
        
    }    
    }
    
  }
