using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TddApp.AdapterPattern.AdapterModels;

namespace TddApp.AdapterPattern
{
    public class Class2_Adapter
    {
        private readonly IFileWriterAdapter _fileWriter;

        public Class2_Adapter(IFileWriterAdapter fileWriter)
        {
            this._fileWriter = fileWriter;
        }

        public void DoStuff()
        {
            string filename = "c:\\test_" + DateTime.Now.ToString("yyyyMMMddHHmmss") + "txt";

            this._fileWriter.Initialise(filename);

            this._fileWriter.WriteLineAsync("Test Line");

            this._fileWriter.Close();

        }
    }
}
