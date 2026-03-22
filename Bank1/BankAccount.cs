using System;

namespace BankAccountNS
{

    public class BankAccount
    {
        private readonly string m_customerName;
        private double m_balance;
        public const string DebitAmountExceedsBalanceMessage = "Debit amount exceeds balance";
        public const string DebitAmountLessThanZeroMessage = "Debit amount is less than zero";

        private BankAccount() { }

        /// <param name="customerName">Имя владельца счёта</param>
        /// <param name="balance">Начальный баланс счёта</param>
        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        /// <summary>
        /// Возвращает имя владельца банковского счёта.
        /// </summary>
        public string CustomerName
        {
            get { return m_customerName; }
        }

        /// <summary>
        /// Возвращает текущий баланс счёта.
        /// </summary>
        public double Balance
        {
            get { return m_balance; }
        }

        /// <param name="amount">Сумма, которую необходимо снять со счёта</param>

        public void Debit(double amount)
        {
            if (amount > m_balance)
            {
                throw new System.ArgumentOutOfRangeException("amount", amount, DebitAmountExceedsBalanceMessage);
            }

            if (amount < 0)
            {
                throw new System.ArgumentOutOfRangeException("amount", amount, DebitAmountLessThanZeroMessage);
            }


            m_balance -= amount;
        }

        /// <param name="amount">Сумма, которую необходимо зачислить на счёт</param>

        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance += amount;
        }

        /// <summary>
        /// Запуск консольного приложения
        /// </summary>
        public static void Main()
        {
            BankAccount ba = new BankAccount("Mr. Roman Abramovich", 11.99);

            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
            Console.ReadLine();
        }
    }
}