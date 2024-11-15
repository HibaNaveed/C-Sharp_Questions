

using System;
class Question4 {
  static void Main() {
       Console.WriteLine("Enter Your Age");
      int age=  Convert.ToInt32(Console.ReadLine());
      
      if(age>=18){
           Console.WriteLine("You are Eligible to vote");
      }
      else{
          Console.WriteLine("You are not Eligible to vote");
      }
    
  }
}
