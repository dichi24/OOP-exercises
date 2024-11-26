class Program
{
    static void Main()
    {
        Customer aCustomer = new Customer("Yunus Tamasanu", 12345);
        aCustomer.Deposit(10000);
        aCustomer.Withdraw(500);
        Console.WriteLine();
        aCustomer.GetBalance();
        Console.WriteLine();
    }
}