using System;
using System.Collections.Generic;

namespace S2.Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            List<Person> people = new List<Person>();
            List<Address> addresses = new List<Address>();

            while(!done)
            {

                Console.WriteLine("1. Tilføj Person\t2. Tilføj Adresse\t3. Hvis Adresser\n");

                char menu = Console.ReadKey(true).KeyChar;

                switch(menu)
                {
                    case '1':

                        while(true)
                        {
                            Console.Write("Indtast navn: ");

                            string nameInput = Console.ReadLine();

                            Console.WriteLine("");
                            Console.Write("Indtast fødselsdag: ");

                            string dateInput = Console.ReadLine();

                            bool isDate = DateTime.TryParse(dateInput, out DateTime birthDateInput);

                            Console.WriteLine("");

                            if(!isDate)
                            {

                                Console.WriteLine("Fødselsdagen var ikke i korrekt format\n");
                                break;
                            }
                            Console.Write("Indtast mail: ");

                            string mailInput = Console.ReadLine();

                            Console.WriteLine("");
                            Console.Write("Indtast telefon nummer: ");

                            string phoneInput = Console.ReadLine();

                            Console.WriteLine("");

                            ContanctInformation contact;
                            Person person;

                            try
                            {
                                contact = new ContanctInformation(mailInput, phoneInput);

                                person = new Person(nameInput, birthDateInput, contact);
                            }
                            catch(Exception ex)
                            {

                                Console.WriteLine("Exception! (" + ex.Message + ")\n");

                                break;
                            }

                            people.Add(person);

                            break;

                        }

                        break;
                    case '2':

                        while(true)
                        {
                            Console.Write("Indtast gadenavn: ");

                            string streetNameInput = Console.ReadLine();

                            Console.WriteLine("");
                            Console.Write("Indtast gadenummer: ");

                            string streetNumberInput = Console.ReadLine();

                            Console.WriteLine("");
                            Console.Write("Indtast zip nummer: ");

                            string zipInput = Console.ReadLine();

                            Console.WriteLine("");
                            Console.Write("Indtast by: ");

                            string cityInput = Console.ReadLine();

                            Console.WriteLine("");
                            Console.Write("Indtast land: ");

                            string countryInput = Console.ReadLine();

                            Console.WriteLine("");

                            Address address;

                            try
                            {

                                address = new Address(streetNameInput, streetNumberInput, zipInput, cityInput, countryInput, people);

                            }
                            catch(Exception ex)
                            {

                                Console.WriteLine("Exception! (" + ex.Message + ")\n");

                                break;
                            }

                            addresses.Add(address);

                            people = new List<Person>();

                            break;

                        }

                        break;
                    case '3':

                        for(int i = 0; i < addresses.Count; i++)
                        {

                            Console.WriteLine($"\n{1 + i}. adresse:" );

                            Console.WriteLine($"Gade navn: {addresses[i].StreetName}, Gade nummer: {addresses[i].StreetNumber}, Zip nummer: {addresses[i].Zip}, By: {addresses[i].City}, Land: {addresses[i].Country}");

                            for(int personI = 0; personI < addresses[i].People.Count; personI++)
                            {
                                Console.WriteLine($"Navn: {addresses[i].People[personI].Name}, Fødselsdag: {addresses[i].People[personI].BirthDate}, Mail: {addresses[i].People[personI].ContanctInfo.Mail}, Telefon nummer: {addresses[i].People[personI].ContanctInfo.Phone}");
                            }
                        }
                        Console.WriteLine("");

                        break;


                }

            }

        }
    }
}
