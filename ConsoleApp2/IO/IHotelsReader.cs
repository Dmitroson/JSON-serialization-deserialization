using ConsoleApp2.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.IO
{
    public interface IHotelsReader
    {
        Hotel GetById(int id);

        List<Hotel> GetAll();
    }
}