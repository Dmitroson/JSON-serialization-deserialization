using ConsoleApp2.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Core.Business
{
    public interface IHotelsManager
    {
        Hotel GetHotelById(int id);

        void AddHotel(Hotel hotel);

        List<Hotel> GetTopHotels();

        //
    }
}
