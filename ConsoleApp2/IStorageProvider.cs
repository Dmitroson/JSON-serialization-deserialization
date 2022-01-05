using ConsoleApp2.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public interface IStorageProvider
    {
        IHotelsReader CreateReader();

        IHotelsWriter CreateWriter();
    }
}
