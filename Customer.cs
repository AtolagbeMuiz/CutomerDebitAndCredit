public class Customer 
{
    // double totalAmount = 0;

    // // public Customer(double creditAmount, double debitAmount)
    // // {
    // //     this._amountCredited = creditAmount;
    // //     this._amountDeited = debitAmount;
    // // }

    // public double addMoney(double amountTobeAdded)
    // {
    //     this.totalAmount += amountTobeAdded;

    //     System.Console.WriteLine($"You have credited your account with {amountTobeAdded} \n your account balance is {totalAmount}");
    //     return totalAmount;
    // }

    // public double deductMoney(double amountTobeDeducted)
    // {
    //     this.totalAmount -= amountTobeDeducted;

    //     System.Console.WriteLine($"You have been debited {amountTobeDeducted} from your account \n your account balance is {totalAmount}");
    //     return totalAmount;
    // }



    //create a customer with two methods called debit and credit.create instance to debit and credit the customer
    decimal CustomerBalance = 1000;
    decimal _credit;
    decimal _debit;

    public Customer(decimal credit, decimal debit)
    {
        _credit = credit;
        _debit = debit;
    }

    public decimal Credit()
    {
        decimal balance = _credit + CustomerBalance;
        return balance;
    }

    public decimal Credit(decimal amount)
    {
        decimal balance = amount + CustomerBalance;
        return balance;
    }

    public decimal Debit(decimal amount)
    {
        decimal balance = CustomerBalance - amount;
        return balance;
    }

    public decimal Debit()
    {
        decimal balance = CustomerBalance - _debit;
        return balance;
    }
}


