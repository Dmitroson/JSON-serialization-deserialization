using ConsoleApp2.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class StorageProvider : IStorageProvider
    {
        private string sourcePath;

        public string SourcePath => sourcePath;

        public StorageProvider(string sourcePath)
        {
            this.sourcePath = sourcePath;
        }

        public IHotelsReader CreateReader()
        {
            return new JsonHotelsReader(SourcePath);
        }

        public IHotelsWriter CreateWriter()
        {
            throw new NotImplementedException();
        }
    }
}
