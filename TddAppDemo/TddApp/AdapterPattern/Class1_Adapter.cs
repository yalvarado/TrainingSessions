using System;
using System.IO;

namespace TddApp.AdapterPattern
{
    public class Class1_Adapter
    {
        public void DoStuff()
        {
            string filename = "c:\\test_" + DateTime.Now.ToString("yyyyMMMddHHmmss") + "txt";
            using (var fileWriter = new StreamWriter(filename))
            {
                fileWriter.WriteLineAsync("Test Line");

                fileWriter.Close();
            }

        }
    }
}
