using System;
using System.Collections.Generic;
using System.Text;

namespace S2.Oop2
{
    public class Person
    {

        private string name;
        private int age;
        private DateTime birthDate;
        private ContanctInformation contanctInfo;

        public string Name
        {
            get => name;

            set
            {

                (bool notValid, string errorMessage) validation = ValidateName(value);

                if(validation.notValid)
                    throw new ArgumentException(validation.errorMessage);

                name = value;
            }
        }

        public int Age => age;

        public DateTime BirthDate
        {
            get => birthDate;

            set
            {

                (bool notValid, string errorMessage) validation = ValidateBirthDate(value);

                if(validation.notValid)
                    throw new ArgumentOutOfRangeException(nameof(birthDate), validation.errorMessage);

                birthDate = value;
            }
        }

        public ContanctInformation ContanctInfo
        {
            get => contanctInfo;

            set
            {

                if(value == null)
                    throw new ArgumentNullException(nameof(contanctInfo), "A person must have contact information");

                if(contanctInfo != value)
                    contanctInfo = value;

            }
        }

        public Person(string name, DateTime birthDate, ContanctInformation contactInfo)
        {

            Name = name;

            BirthDate = birthDate;

            ContanctInfo = contactInfo;

            CalculateAge();

        }

        public Person(string name, DateTime birthDate)
        {

            Name = name;

            BirthDate = birthDate;

            ContanctInfo = new ContanctInformation();

            CalculateAge();

        }

        public void CalculateAge()
        {

            DateTime now = DateTime.Now;

            now.AddDays(-BirthDate.Day);

            now.AddMonths(-BirthDate.Month);

            now.AddYears(-BirthDate.Year);

            age = now.Year;

        }

        public static (bool, string) ValidateName(string name)
        {

            if(string.IsNullOrWhiteSpace(name))
                return (true, "Name cannot be empty.");

            if(!name.Contains(' '))
                return (true, "Name must contain at least 1 space.");

            return (false, string.Empty);

        }

        public static (bool, string) ValidateBirthDate(DateTime birthDate)
        {

            if(birthDate > DateTime.Now.AddDays(-1))
                return (true, "Birthdate cannot be in the future or today.");

            if(birthDate < DateTime.Now.AddYears(-100))
                return (true, "Birthday cannot be more than 100 years ago.");

            return (false, string.Empty);

        }

    }
}
