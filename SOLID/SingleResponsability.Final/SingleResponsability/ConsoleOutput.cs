using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsability
{
    public class ConsoleOutput : IWordsOutput
    {
        public void GenerateOutput(IEnumerable<KeyValuePair<string, int>> wordsList)
        {
            foreach (var word in wordsList)
            {
                Console.WriteLine($"{word.Key} {word.Value}");
            }   
        }
    }
}
