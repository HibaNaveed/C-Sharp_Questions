
using System;
class divisibility {
  static void Main() {
      Console.WriteLine("Enter Number");
      int num=Convert.ToInt32(Console.ReadLine ());
    if(num%5==0){
         Console.WriteLine(num+" "+"Number is divisible by 5");
    }
    else  if(num%11==0){
         Console.WriteLine(num+" "+"Number is divisible by 11");
    }
    else{
         Console.WriteLine(num+" "+" is not divisible by 5 or 11");
    }
    
  }
}