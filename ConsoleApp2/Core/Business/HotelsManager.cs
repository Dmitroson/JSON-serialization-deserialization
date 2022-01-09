using ConsoleApp2.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Core.Business
{
    public class HotelsManager : IHotelsManager
    {
        protected IStorageProvider storageProvider;

        public HotelsManager(IStorageProvider provider)
        {
            storageProvider = provider;
        }

        public void AddHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }

        public Hotel GetHotelById(int id)
        {
            var reader = storageProvider.CreateReader();
            return reader.GetById(id);
        }

        public List<Hotel> GetTopHotels()
        {
            throw new NotImplementedException();
        }
    }
}
