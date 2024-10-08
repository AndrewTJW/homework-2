using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_2
{
    internal class Expense : Transaction
    {
        private double total_expense;
        public Expense (double a_amount, string a_transactionreason, DateTime a_datetime) 
            : base (a_amount, a_transactionreason, a_datetime)
        {

        }
    }
}
