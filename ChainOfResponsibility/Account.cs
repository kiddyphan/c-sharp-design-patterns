using System;

namespace ChainOfResponsibility
{
    public abstract class Account
    {
        private Account _account;
        protected int _balance;

        public void setBackupAccount(Account account)
        {
            this._account = account;
        }

        public void Pay(int amount)
        {
            if (_balance >= amount)
            {
                Console.WriteLine($"Paid {amount} from account {this.GetType().Name}");
            }
            else if (_balance < amount)
            {
                if (this._account != null)
                {
                    Console.WriteLine($"Not enough money, trying {this._account.GetType().Name} Account. Processing...");
                    this._account.Pay(amount);  
                }
                else
                {
                    Console.WriteLine("None of the accounts can pay the bill!");
                }
            }
        }
    }
}