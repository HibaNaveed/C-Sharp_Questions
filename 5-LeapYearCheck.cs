

using System;
class Question5 {
  static void Main() {
       Console.WriteLine("Enter Year");
      int year=  Convert.ToInt32(Console.ReadLine());
      
      if(year%4==0 && year%100!=0){
           Console.WriteLine(year+" "+"is a Leap year");
      }
      else if(year%400==0){
           Console.WriteLine(year+" "+"is a Leap year");
      } 
      else{
          Console.WriteLine(year+" "+"not a Leap year");
      }
    
  }
}
