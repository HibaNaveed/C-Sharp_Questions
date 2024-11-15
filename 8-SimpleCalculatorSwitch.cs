
using System;
class calculator {
  static void Main() {
       Console.WriteLine("Enter First Number");
      double num1= Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Operator");
      char op=Convert.ToChar(Console.ReadLine());
         Console.WriteLine("Enter Second Number");
      double num2= Convert.ToDouble(Console.ReadLine());
      
      switch(op) 
{
  case '+':
   double addition= num1+num2;
        Console.WriteLine(num1 +"+"+ num2+"="+ addition);
    break;
  case '-' :
   double sub= num1-num2;
        Console.WriteLine(num1 +"-"+ num2+"="+ sub);
    break;
    case '*' :
   double mul= num1*num2;
        Console.WriteLine(num1 +"*"+ num2+"="+ mul);
    break;
    case '/' :
   double div= num1/num2;
        Console.WriteLine(num1 +"/"+ num2+"="+ div.ToString("F3") );
    break;
  default:
    Console.WriteLine("Enter Valid Operator");
    break;
}
  }
}