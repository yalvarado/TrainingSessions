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
        //private static readonly string _fileUrl="http://www.loyalbooks.com/download/text/Railway-Children-by-E-Nesbit.txt";
        private static readonly string _fileUrl = @".\Books\Book1.txt";
		private static readonly string _outputFilePath = @".\Words";
		
        static void Main(string[] args)
        {
            Dictionary<string,int> wordsList = new Dictionary<string, int>();


            WebClient client = new WebClient();
            Stream stream = client.OpenRead(_fileUrl);

            using (StreamReader reader = new StreamReader(stream)) //GetStreamReader(_fileUrl))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Remove punctuation
                    StringBuilder output = new StringBuilder();

                    foreach (char character in line)
                    {
                        if (!char.IsPunctuation(character))
                            output.Append(character);
                    }

                    // Add words to the list
                    string[] words = output.ToString().Split(' ');
                    foreach (string word in words)
                    {
                        if (word.Trim().Length == 0)
                            continue;

                        if (wordsList.ContainsKey(word))
                            wordsList[word]++;
                        else
                            wordsList.Add(word,1);
                    }

                }

				string fileName = this._outputFilePath + @"\Output_" + DateTime.Now.ToString("yyyyMMMddHHmmss") + ".txt";

				using (StreamWriter writer = new StreamWriter(fileName))
				{
					// Display results                
					foreach (var word in wordsList.OrderByDescending(item => item.Value))
					{
						string wordLine = $"{word.Key} {word.Value}";
						Console.WriteLine(wordLine);
						writer.WriteLine(wordLine);
					}
                }
            }


            Console.ReadKey();
        }

        //private static StreamReader GetStreamReader(string fileUrl)
        //{
        //    if (fileUrl.Contains("http"))
        //    {
        //        WebClient client = new WebClient();
        //        Stream stream = client.OpenRead(fileUrl);
        //        return new StreamReader(stream);
        //    }

        //    return new StreamReader(fileUrl);
        //}
    }
}
