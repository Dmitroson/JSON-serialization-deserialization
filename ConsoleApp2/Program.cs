using ConsoleApp2;
using ConsoleApp2.Core.Business;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace InterfaceAndJSON
{
    namespace JsonInterface
    {
        public class Program
        {
            private const string Source = "C:\\Users\\Admin\\source\\repos\\ConsoleApp1\\hotels.json";

            static void Main(string[] args)
            {
                IStorageProvider storageProvider = new StorageProvider(Source);
                IHotelsManager manager = new HotelsManager(storageProvider);

                var result = manager.GetHotelById(13);
            }
        }
    }
}