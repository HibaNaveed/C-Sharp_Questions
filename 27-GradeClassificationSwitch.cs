using System;
class Grade {
    static void Main() {
        Console.WriteLine("Enter English Marks:");
        int eng = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter Maths Marks:");
        int maths = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter Urdu Marks:");
        int urdu = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter Physics Marks:");
        int phy = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter Chemistry Marks:");
        int chem = Convert.ToInt32(Console.ReadLine());

        int obt = eng + maths + urdu + phy + chem;
        Console.WriteLine("Obtained Marks: " + obt);


        int Total = 500;
        Console.WriteLine("Total Marks: " + Total);

        double per = (obt / (double)Total) * 100;
        Console.WriteLine("Percentage: " + per.ToString("F2") + "%");

        int gradeCategory = (int)(per / 10); 
        
        switch (gradeCategory) {
            case 10:
            case 9:
                Console.WriteLine("Grade A");
                break;
            case 8:
                Console.WriteLine("Grade B");
                break;
            case 7:
                Console.WriteLine("Grade C");
                break;
            case 6:
                Console.WriteLine("Grade D");
                break;
            default:
                Console.WriteLine("Grade F");
                break;
        }
    }
}
