using CourtBooking.Entities;
using CourtBooking.Service;
using System.Collections.Generic;
using System;

namespace CourtBooking.ManualTest
{
    class Program
    {
        static void Main(string[] args)
        {

            BookingService service = new BookingService("https://api.aspitcloud.dk/bookings");

            while(true)
            {

                Console.Write("Indtast booking id: ");

                char charId = Console.ReadKey().KeyChar;

                bool isNum = Int32.TryParse(charId.ToString(), out int bookingId);

                Console.WriteLine();

                try
                {

                    List<Booking> bookings = service.GetManyBookings();

                    if(!isNum || bookings.Count < bookingId || bookingId < 1)
                    {
                        Console.WriteLine("\nId findes ikke");
                        Console.WriteLine();
                        continue;
                    }

                    Booking booking = service.GetSingleBooking(bookingId);

                    Console.WriteLine("\n" + booking);

                    Console.WriteLine();

                    for(int i = 0; i < bookings.Count; i++)
                    {
                        Console.WriteLine(bookings[i]);
                    }


                }
                catch(Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

                Console.ReadLine();
                break;
            }

        }
    }
}
