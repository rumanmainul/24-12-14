using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationApp
{
    class Customer
    {
        private string accountNumber;
        private string customerName;
        private int balance;

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }


        public void DoDeposit(int amount)
        {
            Balance += amount;
        }

        public void DoWithdraw(int amount)
        {
            Balance -= amount;
        }

    }
}
