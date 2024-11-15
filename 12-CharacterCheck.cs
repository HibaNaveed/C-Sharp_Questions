
using System;
class vowels {
  static void Main() {
       Console.WriteLine("Enter Letter");
      char letter= Convert.ToChar(Console.ReadLine());
      switch(letter) 
{
    case 'a':
     case 'A':
        Console.WriteLine(letter+" "+"is vowel");
    break;
    case 'e':
     case 'E':
          Console.WriteLine(letter+" "+"is vowel");   
    break;
    case 'i':
     case 'I':
         Console.WriteLine(letter+" "+"is vowel");
    break;
    
    case 'o':
     case 'O':
         Console.WriteLine(letter+" "+"is vowel");
    break;
    
    case 'u':
     case 'U':
         Console.WriteLine(letter+" "+"is vowel");
    break;
    
  default:
     Console.WriteLine(letter+" "+"is Consonant");
    break;
}
  }
}