using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SingleResponsability
{
    public class LocalInputStream : IInputStream
    {
        private readonly string _url = @".\Books\Book1.txt";


        public StreamReader GetStream()
        {
            if (this._url.Contains("http"))
                return null;

            return new StreamReader(this._url);
        }
    }
}
