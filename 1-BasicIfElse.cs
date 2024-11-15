

using System;
class Question1 {
  static void Main() {
       Console.WriteLine("Enter Number");
      int num=  Convert.ToInt32(Console.ReadLine());
      if(num<0){
           Console.WriteLine("Number is Negative");
      }
      else if(num==0){
          Console.WriteLine("Number is Zero");
      }
      else{
          Console.WriteLine("Number is Positive");
      }
    
  }
}