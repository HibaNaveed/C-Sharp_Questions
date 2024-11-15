
using System;
class characterclassification {
  static void Main() {
      Console.WriteLine("Enter Character");
      char character=Convert.ToChar(Console.ReadLine ());
      
    if(char.IsUpper(character)){
             Console.WriteLine("The Character is in Upper case");
        }
    else if(char.IsLower(character)){
             Console.WriteLine("The Character is in Lower case");
        }   
    else if(char.IsDigit(character)){
             Console.WriteLine("The Character is a Digit");
        }     
        else{
          Console.WriteLine("The Character is special character");
        }
        
    }    
    }
    
  
