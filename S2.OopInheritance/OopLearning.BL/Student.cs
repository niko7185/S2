using System;
using System.Collections.Generic;
using System.Text;

namespace S2.OopInheritance.OopLearning.BL
{
    public class Student : Person
    {

        private string unilogin;

        public string Unilogin
        {
            get
            {
                return unilogin;
            }

            set
            {
                if(string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(nameof(Unilogin), "Unilogin cannot be empty");

                unilogin = value;
            }
        }

        public Student(string name, string cpr, string unilogin) : base(name, cpr)
        {
            Unilogin = unilogin;
        }

    }
}
