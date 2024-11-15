using System;

class PalindromeChecker
{
    static void Main()
    {

        Console.WriteLine("Enter a word or number to check whether it is a palindrome or not");
        string input = Console.ReadLine().Trim();  


        string reverse = string.Empty;
 bool isNumber = true;
        foreach (char c in input)
        {
            if (!char.IsDigit(c))
            {
                isNumber = false;  
                break;
            }
        }

        if (isNumber)
        {
         
            string numberString = input;
            for (int i = numberString.Length - 1; i >= 0; i--)
            {
                reverse += numberString[i];
            }

            if (numberString == reverse)
            {
                Console.WriteLine(input+" "+"is a palindrome.");
            }
            else
            {
                Console.WriteLine(input+" "+" is not a palindrome.");
            }
        }
        else
        {
            string word = input.ToLower();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse += word[i];
            }

            if (word == reverse)
            {
                Console.WriteLine(input+" "+"  is a palindrome.");
            }
            else
            {
                Console.WriteLine(input+" "+"  is not a palindrome.");
            }
        }
    }
}
