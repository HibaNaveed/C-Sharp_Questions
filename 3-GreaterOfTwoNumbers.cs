

using System;
class Question3 {
  static void Main() {
       Console.WriteLine("Enter First Number");
      int num1=  Convert.ToInt32(Console.ReadLine());
      
       Console.WriteLine("Enter Second Number");
      int num2=  Convert.ToInt32(Console.ReadLine());
      
      if(num1>num2){
           Console.WriteLine(num1 +" "+"is Greater than"+" "+num2);
      }
      else if(num2>num1){
           Console.WriteLine(num2 +" "+"is Greater than"+" "+num1);
      }
      else{
          Console.WriteLine("Both Numbers are equal");
      }
    
  }
}
