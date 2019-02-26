using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsability
{
    public interface IWordsOutput
    {
        void GenerateOutput(IEnumerable<KeyValuePair<string,int>> wordsList);
    }
}
