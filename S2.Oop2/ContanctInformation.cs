using System;
using System.Collections.Generic;
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

                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(mail), "Mail cannot be empty");
                }

                mail = value;

            }
        }

        public string Phone
        {
            get => phone;

            set
            {

                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(phone), "Phone number cannot be empty");
                }

                phone = value;
            }
        }

        public ContanctInformation(string mail, string phone)
        {

            Mail = mail;

            Phone = phone;

        }


    }
}
