using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SingleResponsability
{
    public interface IInputStream
    {
        StreamReader GetStream();
    }
}
