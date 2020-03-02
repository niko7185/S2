using System;
using System.Collections.Generic;
using System.Text;

namespace S2.OopInheritance.OopLearning.BL
{
    public class Employee : Person
    {

        private string initials;


        public string Initials
        {
            get
            {
                return initials;
            }

            set
            {
                if(string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(nameof(Initials), "Initials cannot be empty");

                initials = value;
            }
        }

        public Employee(string name, string cpr, string initials) : base(name, cpr)
        {
            Initials = initials;
        }
    }
}
