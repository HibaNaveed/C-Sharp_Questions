

using System;
class Question7 {
  static void Main() {
    Console.WriteLine("Enter English Marks");
   int eng=Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Enter Maths Marks");
      int maths=Convert.ToInt32(Console.ReadLine()); 
      Console.WriteLine("Enter Urdu Marks");
       int urdu=Convert.ToInt32(Console.ReadLine()); 
       Console.WriteLine("Enter Physics Marks");
        int phy=Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("Enter Chemistry Marks");
          int chem=Convert.ToInt32(Console.ReadLine());
    int obt= eng+maths+urdu+phy+chem;
    Console.WriteLine("Obtained Marks"+" "+obt);
    int Total=500;
    Console.WriteLine("Total Marks"+" "+Total);
    double per;
         per=obt / (double)Total*100;
       Console.WriteLine("Percentage "+per.ToString("F2")+"%");
      
      if(per>=80 && per<=100){
          Console.WriteLine("Grade A");
      }
      else if(per>=70 && per<=79){
          Console.WriteLine("Grade B");
      } 
      else if(per>=60 && per<=69){
          Console.WriteLine("Grade C");
      } 
        else if(per>=50 && per<=59){
          Console.WriteLine("Grade D");
      } 
      else{
          Console.WriteLine("Grade F");
      }
    
  }
}
