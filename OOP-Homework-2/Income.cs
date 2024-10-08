using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_2
{
    internal class Income : Transaction
    {
        private double total_income;
        public Income(double a_amount, string a_transactionreason, DateTime a_datetime)
    : base(a_amount, a_transactionreason, a_datetime)
        {

        }
    }
}
