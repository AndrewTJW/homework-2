using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace OOP_Homework_2
{
    internal class TransactionList
    {
        private List<Transaction> Transactions;

        public TransactionList()
        {
            Transactions = new List<Transaction>();
        }

        public void AddTransaction(Transaction a_transaction)
        {
            Transactions.Add(a_transaction);
        }
        public void RemoveTransaction(Transaction a_transaction)
        {
            Transactions.Remove(a_transaction);
        }
        public void DisplayTransactionHistory()
        {
            foreach (Transaction tmp in Transactions)
            {
                tmp.DisplayTransactionDetails();
            }
        }

        public double getTotalRevenue()
        {
            double total = 0;
            foreach (Transaction tmp in Transactions)
            {
                if (tmp is Income tmp_income)
                {
                    total += tmp_income.getAmount();
                }
            }
            return total;
        }

        public double getTotalExpense()
        {
            double total = 0;
            foreach(Transaction tmp in Transactions)
            {
                if (tmp is Expense tmp_expense)
                {
                    total -= tmp_expense.getAmount();
                }
            }
            return total;
        }
    }
}

