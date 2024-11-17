using System;

class ATM
{
    static void Main()
    {
         double balance = 6000.00; 
        int choice;
        double amount;
        
       Console.WriteLine(" ATM ");
       Console.WriteLine("\n Select an option:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice (1-4): ");
            choice = Convert.ToInt32(Console.ReadLine());
            
     switch (choice)
            {
                case 1: 
                    Console.WriteLine($"Your current balance is: " + balance);
                    break;

                case 2: 
                    Console.Write("Enter the amount to deposit: ");
                    amount = Convert.ToDouble(Console.ReadLine());
                    if (amount > 0)
                    {
                        balance += amount;
                        Console.WriteLine($"You have successfully deposited:"+amount+" Your new balance is:"+balance);
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount!");
                    }
                    break;

                case 3: 
                    Console.Write("Enter the amount to withdraw: ");
                    amount = Convert.ToDouble(Console.ReadLine());
                    if (amount > 0 && amount <= balance)
                    {
                        balance -= amount;
                        Console.WriteLine($"You have successfully withdrawn: "+amount+" Your new balance is: "+balance);
                    }
                    else if (amount > balance)
                    {
                        Console.WriteLine("Insufficient balance!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount!");
                    }
                    break;

                case 4: 
                    Console.WriteLine("Thank you for using the ATM.");
                    break;

                default: 
                    Console.WriteLine("Invalid option!");
                    break;
            }
        } 
    
}        