using ConsoleApp2.Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp2.IO
{
    public class JsonHotelsReader : IHotelsReader
    {
        public string SourcePath { get; }

        public JsonHotelsReader(string path)
        {
            SourcePath = path;
        }

        public List<Hotel> GetAll()
        {
            if (!File.Exists(SourcePath))
                throw new Exception("File not found.");

            string jsonString = File.ReadAllText(SourcePath);
            var hotels = JsonConvert.DeserializeObject<List<Hotel>>(jsonString);

            if (hotels == null)
                throw new Exception("File is invalid.");

            return hotels;
        }

        public Hotel GetById(int id)
        {
            if (!File.Exists(SourcePath))
                throw new Exception("File not found.");

            string jsonString = File.ReadAllText(SourcePath);
            var hotels = JsonConvert.DeserializeObject<List<Hotel>>(jsonString);

            if (hotels == null)
                throw new Exception("File is invalid.");

            return hotels.FirstOrDefault(h => h.HotelId == id);
        }
    }
}
