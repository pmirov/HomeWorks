using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_9_2
{
    internal class BankAccount
    {
        public static int _totalAccounts;

        public int AccountNumber { get; }
        public decimal Balance { get; private set; }
        private Random random = new Random();

        public BankAccount()
        {
            AccountNumber = random.Next(1000, 9999);
            _totalAccounts++;
        }

       

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Баланс пополнен на {amount} руб.");
        }

        public void Withdraw(decimal amount)
        {
            try
            {
   
                if ((Balance-amount) < 0)
                {
                    throw new Exception("На балансе не хватает денег!");
                }
                else
                {
                    Balance -= amount;
                    Console.WriteLine($"С баланса снято {amount} руб.");
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");

            }
        }

        public static void ShowTotalAccouts()
        {
            Console.WriteLine($"Количество созданных аккаунтов: {_totalAccounts}");
        }
    }
}
