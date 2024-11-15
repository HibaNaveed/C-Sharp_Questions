using System;

class ATM
{
    static void Main()
    {
        int pin = 1234;
        double balance = 1000.0;  
        int enterPin;
        bool auth = false;

        Console.WriteLine("Enter your PIN to access the ATM: ");
        enterPin = Convert.ToInt32(Console.ReadLine());
        if (enterPin == pin)
        {
            auth = true;
            Console.WriteLine("PIN correct. Welcome");
        }
        else
        {
            Console.WriteLine("Incorrect PIN. Access denied.");
            return;
        }

        while (auth)
        {
            Console.WriteLine("\nATM Menu:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Please select an option (1-4): ");
            
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine($"Your current balance is:"+ balance);
                    break;

                case 2:
                    Console.WriteLine("Enter the amount to deposit:");
                    double depositAmount = Convert.ToDouble(Console.ReadLine());
                    if (depositAmount > 0)
                    {
                        balance += depositAmount;
                        Console.WriteLine($"You have successfully deposited:"+depositAmount+" Your new balance is:"+balance);
                    }
                    else
                    {
                        Console.WriteLine("Invalid deposit amount. Please enter a positive number.");
                    }
                    break;

                case 3:
            
                    Console.WriteLine("Enter the amount to withdraw: $");
                    double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                    if (withdrawAmount > 0 && withdrawAmount <= balance)
                    {
                        balance -= withdrawAmount;
                        Console.WriteLine($"You have successfully withdrawn: "+withdrawAmount+" Your new balance is:"+balance);
                    }
                    else if (withdrawAmount > balance)
                    {
                        Console.WriteLine("Insufficient balance. Try a lower amount.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid withdrawal amount. Please enter a positive number.");
                    }
                    break;

                case 4:
                   
                    Console.WriteLine("Thank you.");
                    auth = false; 
                    break;

                default:
                    Console.WriteLine("Invalid Option. Please select a valid option (1-4).");
                    break;
            }
        }
    }
}
