using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_2
{
    internal class People
    {
        private string name { get; set; }
           
        private int age { get; set; }

        public People (string a_name, int a_age)
        {
            name = a_name;
            age = a_age;
        }

        public string getName()
        {
            return name;
        }
        public int getAge()
        {
            return age;
        }
    }
}
