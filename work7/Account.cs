using System;


namespace work7
{
    internal class Account
    {
        private string accountNumber;

        public string AccountNumber
        {
            get
            {
                return accountNumber;
            }
            set
            {
                if(value.Length==22) 
                {
                    accountNumber = value;
                }
            }
        }
        private string currency;
        public string Currency
        {
            get
            {
                return currency;
            }
            set
            {
                if(value.Length==3)
                {
                    currency = value;    
                }
            }
        }
        private decimal balance;
        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value > 0)
                {
                    balance = value;
                }
            }
        }

        public Account(string accountNumber,string currency,decimal balance)
        {
            AccountNumber = accountNumber;
            Currency = currency;
            Balance = balance;
        }

        public void CashingOut(decimal amount)
        {

            Balance -= amount;
        }

        public void ReplenishmentOfTheBalance(decimal amount)
        {
            Balance += amount;
        }

        public void Transfer(Account account,decimal amount)
        {
            CashingOut(amount);
            account.ReplenishmentOfTheBalance(amount);
        }

    }
}
