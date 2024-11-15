
using System;
class oddeven {
  static void Main() {
       Console.WriteLine("Enter Number");
      int num= Convert.ToInt32(Console.ReadLine());
      switch(num%2) 
{
  case 0:
        Console.WriteLine(num+" "+"is even");
    break;
    case 1:
        Console.WriteLine(num+" "+"is Odd");
    break;
  default:
    Console.WriteLine("Error");
    break;
}
  }
}