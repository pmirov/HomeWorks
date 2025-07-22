namespace Task1_9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount();

            acc1.Deposit(200);
            Console.WriteLine(acc1.Balance);
            acc1.Withdraw(300);
            Console.WriteLine(acc1.Balance);
            acc1.Withdraw(100);
            Console.WriteLine(acc1.Balance);
            BankAccount acc2 = new BankAccount();
            BankAccount acc3 = new BankAccount();
            BankAccount.ShowTotalAccouts();
            Console.WriteLine($"Номера счетов: {acc1.AccountNumber}, {acc2.AccountNumber}, {acc3.AccountNumber}");


        }
    }
}