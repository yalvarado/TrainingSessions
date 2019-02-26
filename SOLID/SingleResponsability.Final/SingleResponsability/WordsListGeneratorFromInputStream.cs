using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SingleResponsability
{
    public class WordsListGeneratorFromInputStream : IWordListGenerator
    {
        private readonly IInputStream _inputStream;
        private Dictionary<string,int> _wordsList = new Dictionary<string, int>();

        public WordsListGeneratorFromInputStream(IInputStream inputStream)
        {
            this._inputStream = inputStream;
        }

        public Dictionary<string, int> GenerateList()
        {
            using (StreamReader reader = this._inputStream.GetStream())
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string output = this.RemovePunctuation(line);
                    AddWordsToTheList(output);
                }
            }

            return this._wordsList;

        }

        private string RemovePunctuation(string line)
        {
            StringBuilder output = new StringBuilder();

            foreach (char character in line)
            {
                if (!char.IsPunctuation(character))
                    output.Append(character);
            }
            return output.ToString();
        }

        private void AddWordsToTheList(string output)
        {
            string[] words = output.Split(' ');
            foreach (string word in words)
            {
                if (word.Trim().Length == 0)
                    continue;

                if (_wordsList.ContainsKey(word))
                    _wordsList[word]++;
                else
                    _wordsList.Add(word, 1);
            }
        }
    }
}
