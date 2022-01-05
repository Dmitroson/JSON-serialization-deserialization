using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Core.Models
{
    public class Hotel
    {
        public string Name { get; set; }
        public int HotelId { get; set; }
        public string FoundedDate { get; set; }
        public int TouristСapacity { get; set; }
        public int Rating { get; set; }

        public Hotel(string name, int hotelId, string foundedDate, int touristСapacity, int rating)
        {
            this.Name = name;
            this.HotelId = hotelId;
            this.FoundedDate = foundedDate;
            this.TouristСapacity = touristСapacity;
            this.Rating = rating;
        }
    }
}
