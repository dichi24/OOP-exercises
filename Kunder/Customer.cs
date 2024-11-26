class Customer
{
    public string name;
    public int id;
    public double balance;

    public Customer(string name, int id)
    {
        this.name = name;
        this.id = id;
        balance = 0;
    }

    public void Deposit(double amount)
    {
        balance = amount + balance;
    }

    public void Withdraw(double amount)
    {
        if (balance > amount)
        {
            balance = balance - amount;
        }

        else 
        {
            Console.WriteLine("You have no money");
        }
    }

    public double GetBalance()
    {
     Console.WriteLine($"Customer name is {name} and he have {balance} kr. left in his bank account");
     return balance;
    }
}
    
