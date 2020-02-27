using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace S2.Oop2
{
    public class ContanctInformation
    {

        private string mail;
        private string phone;

        public string Mail
        {
            get => mail;

            set
            {

                (bool notValid, string errorMessage) validation = ValidateMail(value);

                if(validation.notValid)
                    throw new ArgumentException(validation.errorMessage);

                mail = value;

            }
        }

        public string Phone
        {
            get => phone;

            set
            {

                (bool notValid, string errorMessage) validation = ValidatePhone(value);

                if(validation.notValid)
                    throw new ArgumentException(validation.errorMessage);

                phone = value;
            }
        }

        public ContanctInformation(string mail, string phone)
        {

            Mail = mail;

            Phone = phone;

        }

        public ContanctInformation()
        {

            Mail = "-----@mail.mail";

            Phone = "00000000000";
        }

        public static (bool, string) ValidateMail(string mail)
        {

            if(string.IsNullOrWhiteSpace(mail))
                return (true, "Mail cannot be empty.");

            if(!mail.Contains("@") || !mail.Contains("."))
                return (true, "Mail must contain a domain.");

            return (false, string.Empty);

        }

        public static (bool, string) ValidatePhone(string phone)
        {

            if(string.IsNullOrWhiteSpace(phone))
                return (true, "Phone number cannot be empty.");

            if(!phone.Any(c => char.IsDigit(c)))
                return (true, "Phone number must contain at least 1 number.");

            return (false, string.Empty);

        }

    }
}
