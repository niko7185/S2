using System;
using System.Collections.Generic;
using System.Text;

namespace CourtBooking.Entities
{
    public class Booking
    {

        protected int courtNumber;
        protected DateTime bookingTime;
        protected string booker;

        public int CourtNumber
        {
            get => courtNumber;

            set
            {

                if(value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(CourtNumber), "Court number must be above 0");

                courtNumber = value;
            }
        }

        public DateTime BookingTime
        {
            get => bookingTime;

            set
            {

                if(value <= DateTime.Now.AddYears(-10))
                    throw new ArgumentOutOfRangeException(nameof(BookingTime), "Booking time cannot be more than 10 years old");

                bookingTime = value;
            }
        }

        public string Booker
        {
            get => booker;

            set
            {
                if(string.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException(nameof(Booker), "Booker cannot be empty");

                booker = value;
            }
        }

        public Booking(int courtNumber, DateTime bookingTime, string booker)
        {

            CourtNumber = courtNumber;

            BookingTime = bookingTime;

            Booker = booker;

        }

        public override string ToString()
        {
            return $"Court number: {CourtNumber}, Booking time: {BookingTime}, Booker: {Booker}\n";
        }

    }
}
