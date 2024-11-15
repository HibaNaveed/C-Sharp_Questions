
using System;
class Eligibility {
  static void Main() {
      Console.WriteLine("Enter Your Age");
      int age= Convert.ToInt32(Console.ReadLine ());
      
    if(age>=18){
         Console.WriteLine("Have you passed the test?");
        bool testresult=Convert.ToBoolean(Console.ReadLine ());
      
      
        if(testresult){
             Console.WriteLine("You are eligible for a driving license");
        }
        else{
             Console.WriteLine("You are not eligible for a driving license because you did not pass the test.");
        }    
    }
        else{
          Console.WriteLine("You are not eligible for a driving license because you are under 18");
        }
        
    }    
    }
    
  
