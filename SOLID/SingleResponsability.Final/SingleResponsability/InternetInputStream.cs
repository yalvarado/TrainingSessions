using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace SingleResponsability
{
    public class InternetInputStream : IInputStream
    {
        private readonly string _url = "http://www.loyalbooks.com/download/text/Railway-Children-by-E-Nesbit.txt";

        public StreamReader GetStream()
        {
            if (this._url.Contains("http"))
            {
                WebClient client = new WebClient();
                Stream stream = client.OpenRead(this._url);
                return new StreamReader(stream);
            }

            return null;
        }
    }
}
