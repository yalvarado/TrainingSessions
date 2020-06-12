using System;
using System.IO;
using System.Threading.Tasks;

namespace TddApp.AdapterPattern.AdapterModels
{
    public interface IFileWriterAdapter
    {
        void Initialise(string fileName);
        Task WriteLineAsync(string text);

        void Close();
    }

    public class FileWriterAdapter : IFileWriterAdapter
    {
        private StreamWriter _fileWriter;

        public void Initialise(string fileName)
        {
            this._fileWriter = new StreamWriter(fileName);
        }

        public Task WriteLineAsync(string text)
        {
            if(this._fileWriter==null)
                throw new Exception("Initialise method has not been called");

            return this._fileWriter.WriteLineAsync(text);
        }

        public void Close()
        {            
            this._fileWriter?.Close();
        }

        
    }
}
