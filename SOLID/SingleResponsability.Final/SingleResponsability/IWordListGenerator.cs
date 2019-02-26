using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsability
{
    public interface IWordListGenerator
    {
        Dictionary<string, int> GenerateList();
    }
}
