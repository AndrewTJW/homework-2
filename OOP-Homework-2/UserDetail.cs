using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_2
{
    internal class UserDetail : People
    {
        private string email { get; set; }
        private string password { get; set; }

        // when the email and password when checked are not valid, an exception is thrown causing the failure to create object
        public UserDetail (string a_email, string a_password, string a_name, int a_age) : base (a_name, a_age)
        {
            email = ValidateEmail(a_email);
            password = ValidatePassword(a_password);
        }

        private string ValidateEmail (string a_email)
        {
            if (string.IsNullOrWhiteSpace(a_email) == false && a_email.Contains("@") == true && a_email.EndsWith(".com") == true)
            {
                return a_email;
            }
            else
            {
                throw new ArgumentException("Invalid gmail");
            }
        }

        private string ValidatePassword (string a_password)
        {
            if (string.IsNullOrWhiteSpace(a_password) == false)
            {
                return a_password;
            }
            else
            {
                throw new ArgumentException("Password can't be empty!");
            }
        }

        public string getEmail()
        {
            return email;
        }
        public string getPassword()
        {
            return password;
        }
    }
}
