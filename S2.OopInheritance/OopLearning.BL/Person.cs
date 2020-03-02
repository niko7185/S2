using System;
using System.Collections.Generic;
using System.Text;

namespace S2.OopInheritance.OopLearning.BL
{
    public class Person
    {

        protected string name;
        protected DateTime birthDay;
        protected string cpr;
        protected bool isWoman;

        public string Name
        {
            get => name;
            
            set
            {

                if(string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(nameof(name), "Name cannot be empty");


                name = value;
            }
        }
        public DateTime BirthDay
        {
            get => birthDay;

            set
            {

                if(value > DateTime.Now)
                    throw new ArgumentOutOfRangeException(nameof(name), "Birthdate cannot be in the future");

                if(value <= DateTime.Now.AddYears(-100))
                    throw new ArgumentOutOfRangeException(nameof(name), "Birthdate cannot be 100 years ago");


                birthDay = value;
            }
        }

        public string Cpr
        {
            get => cpr;

            set
            {

                if(string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(nameof(cpr), "Cpr number cannot be empty");

                string last4Chars = value.Substring(6);
                string first6Chars = value.Substring(0, 6);

                bool isNum = Int32.TryParse(last4Chars, out int last4Digits);
                bool isDate = DateTime.TryParse(first6Chars, out DateTime birthDate);

                if(!isDate)
                    throw new ArgumentNullException(nameof(cpr), "The first 6 digits of the cpr number must be a valid date");

                if(!isNum)
                    throw new ArgumentNullException(nameof(cpr), "The last 4 digits of the cpr number must be numbers");

                cpr = value;

                BirthDay = birthDate;

                isWoman = (last4Digits % 2 == 0) ? true : false;
            }
        }

        public bool IsWoman => isWoman;

        public Person(string name, string cpr)
        {

            Name = name;

            Cpr = cpr;

        }


    }
}
