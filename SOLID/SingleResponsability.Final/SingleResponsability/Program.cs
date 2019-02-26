using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace SingleResponsability
{
    class Program
    {
        static void Main(string[] args)
        {            

            IWordListGenerator wordsListGenerator = new WordsListGeneratorFromInputStream(GetInputProcessor());

            ProcessOutputs(wordsListGenerator.GenerateList());

            Console.ReadKey();
        }


        private static IInputStream GetInputProcessor()
        {
            return new InternetInputStream();
            //return new LocalInputStream();
        }

        private static void ProcessOutputs(Dictionary<string,int> wordsList)
        {
            List<IWordsOutput> outputProcessors = new List<IWordsOutput>()
            {
                new ConsoleOutput(),
                new TextFileOutput()
            };

            foreach (var processor in outputProcessors)
            {
                processor.GenerateOutput(wordsList.OrderByDescending(item => item.Value));
            }
        }




    }
}
