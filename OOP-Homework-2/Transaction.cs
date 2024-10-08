using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_2
{
    internal class Transaction
    {
        private string TransactionReason { get; set; }
        private double amount { get; set; }
        private DateTime TransactionDate { get; set; }
        
        public Transaction (double a_amount, string a_transactionreason, DateTime a_datetime)
        {
            amount = a_amount;
            TransactionReason = a_transactionreason;
            TransactionDate = a_datetime;
        }

        public double getAmount()
        {
            return amount;
        }

        public string getTransactionReason ()
        {
            return TransactionReason;
        }

        public DateTime getTransactionDateTime ()
        {
            return TransactionDate;
        }

        public void DisplayTransactionDetails()
        {
            Console.WriteLine("Amount: {0} Date Time: {1} Reason: {2} ", amount, TransactionDate, TransactionReason);
        }
    }
}
