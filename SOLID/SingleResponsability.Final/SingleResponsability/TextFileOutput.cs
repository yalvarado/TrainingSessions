using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SingleResponsability
{
    public class TextFileOutput : IWordsOutput
    {
        private readonly string _outputFilePath = @".\Words";
        public void GenerateOutput(IEnumerable<KeyValuePair<string, int>> wordsList)
        {
            string fileName = this._outputFilePath + @"\Output_" + DateTime.Now.ToString("yyyyMMMddHHmmss") + ".txt";

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var word in wordsList)
                {
                    writer.WriteLine($"{word.Key} {word.Value}");
                }
            }
        }
    }
}
