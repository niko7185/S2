using CourtBooking.Entities;
using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using System.Text;

namespace CourtBooking.Service
{
    public class BookingService
    {

        protected readonly string url;

        public BookingService(string url)
        {
            this.url = url;
        }

        public Booking GetSingleBooking(int id)
        {

            string jsonResult;
            string specificUrl = $"{url}/{id}";

            using(WebClient client = new WebClient())
            {

                jsonResult = client.DownloadString(specificUrl);

            }

            Booking booking = JsonConvert.DeserializeObject<Booking>(jsonResult);

            return booking;

        }

        public List<Booking> GetManyBookings()
        {
            string jsonResult;

            using(WebClient client = new WebClient())
            {

                jsonResult = client.DownloadString(url);

            }

            List<Booking> bookings = JsonConvert.DeserializeObject<List<Booking>>(jsonResult);
            return bookings;
        }

    }
}
