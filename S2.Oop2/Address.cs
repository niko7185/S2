using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace S2.Oop2
{
    public class Address
    {

        private string streetName;
        private string streetNumber;
        private string zip;
        private string city;
        private string country;
        private List<Person> people;

        public string StreetName
        {
            get => streetName;

            set
            {

                (bool notValid, string errorMessage) validation = ValidateStreetName(value);

                if(validation.notValid)
                    throw new ArgumentException(validation.errorMessage);

                streetName = value;
            }
        }

        public string StreetNumber
        {
            get => streetNumber;

            set
            {

                (bool notValid, string errorMessage) validation = ValidateNumber(value, "Street number");

                if(validation.notValid)
                    throw new ArgumentException(validation.errorMessage);

                streetNumber = value;
            }
        }

        public string Zip
        {
            get => zip;

            set
            {

                (bool notValid, string errorMessage) validation = ValidateNumber(value, "Zip number");

                if(validation.notValid)
                    throw new ArgumentException(validation.errorMessage);

                zip = value;
            }
        }

        public string City
        {
            get => city;

            set
            {

                (bool notValid, string errorMessage) validation = ValidatePlace(value, "city");

                if(validation.notValid)
                    throw new ArgumentException(validation.errorMessage);

                city = value;
            }
        }

        public string Country
        {
            get => country;

            set
            {

                (bool notValid, string errorMessage) validation = ValidatePlace(value, "country");

                if(validation.notValid)
                    throw new ArgumentException(validation.errorMessage);

                country = value;
            }
        }

        public List<Person> People
        {
            get => people;

            set
            {

                (bool notValid, string errorMessage) validation = ValidatePeople(value);

                if(validation.notValid)
                    throw new ArgumentException(validation.errorMessage);

                people = value;
            }
        }

        public Address(string streetName, string streetNumber, string zip, string city, string country, List<Person> people)
        {

            StreetName = streetName;

            StreetNumber = streetNumber;

            Zip = zip;

            City = city;

            Country = country;

            People = people;

        }

        public (bool, string) ValidateStreetName(string streetName)
        {

            if(string.IsNullOrWhiteSpace(streetName))
                return (true, "Street name cannot be empty.");

            if(streetName.Length < 4)
                return (true, "Street name must contain 4 or more characters.");

            return (false, string.Empty);

        }

        public (bool, string) ValidateNumber(string number, string varName)
        {

            if(string.IsNullOrWhiteSpace(number))
                return (true, varName + " cannot be empty.");

            if(!number.Any(c => char.IsDigit(c)))
                return (true, varName + " must contain at least 1 number.");

            return (false, string.Empty);

        }

        public (bool, string) ValidatePlace(string place, string varName)
        {

            if(string.IsNullOrWhiteSpace(place))
                return (true, varName + " cannot be empty.");

            if(place[0].ToString() != place[0].ToString().ToUpper())
                return (true, "The first letter of a " + varName + " must be uppercase.");

            if(place.Length < 4)
                return (true, varName + " must contain 4 or more characters.");

            return (false, string.Empty);

        }

        public (bool, string) ValidatePeople(List<Person> people)
        {

            bool hasMatched = false;

            for(int indexToMatch = 0; indexToMatch < people.Count; indexToMatch++)
            {

                for(int i = 0; i < people.Count; i++)
                {

                    if(people[indexToMatch].ContanctInfo.Mail == people[i].ContanctInfo.Mail && people[indexToMatch].ContanctInfo.Phone == people[i].ContanctInfo.Phone && i != indexToMatch)
                        hasMatched = true;

                }
            }

            if(hasMatched)
                return (true, "Multiple people cannot have the same contact information.");

            if(people.Count < 1)
                return (true, "No people lives on this address.");

            return (false, string.Empty);

        }

    }
}
