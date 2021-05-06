using System;

namespace CustomerDebitAndCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Customer customer = new Customer();
            // System.Console.WriteLine("Welcome to the bank services!!!");
            // System.Console.WriteLine("Press 1 to credit.. Press 2 to debit from your account");
            // var input = double.Parse(Console.ReadLine());

            // if(input == 1)
            // {
            //     System.Console.WriteLine("How much do you want to credit your account with?");
            //     var creditAmounnt = double.Parse(Console.ReadLine());
            //     customer.addMoney(creditAmounnt);
            // }
            // else if (input == 2)
            // {
            //     System.Console.WriteLine("How much do you want to debit from your your account?");
            //     var debitAmount = double.Parse(Console.ReadLine());
            //     customer.deductMoney(debitAmount);
            // }
            // else
            // {
            //     System.Console.WriteLine("Enter a Valid input");
            // }



            Console.WriteLine("Press 1 for credit or 2 for debit or 3 to quit");
            var value1 = int.Parse(Console.ReadLine());
            var customer = new Customer(600, 500);

            var credit = customer.Debit();
            Console.WriteLine($"This is balance from a construtor: {credit}");

            var debit = customer.Credit();
            Console.WriteLine($"This is balance from a construtor: {debit}");

            Console.WriteLine("Press 1 for credit or 2 for debit or 3 to quit");
            var value = int.Parse(Console.ReadLine());
            do
            {
                if (value == 1)
                {
                    Console.WriteLine("Please enter amout to credit");
                    var amount = decimal.Parse(Console.ReadLine());
                    var balance = customer.Credit(amount);
                    Console.WriteLine($"Your new balance is: {balance}");
                }
                else if (value == 2)
                {
                    Console.WriteLine("Please enter amout to debit");
                    var amount = decimal.Parse(Console.ReadLine());
                    var balance = customer.Debit(amount);
                    Console.WriteLine($"Your new balance is: {balance}");
                }
                else if (value == 3)
                {
                    System.Console.WriteLine("Thanks for banking with us");
                    Environment.Exit(0);
                }
                
            } while (value <= 2);




            int sum = 0;

            
        }
    }
}
