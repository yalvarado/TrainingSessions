using System;

namespace CheapWow.Helpers
{
    public interface IConsole
    {
        void Write(string text);
        void WriteLine(string text);
        void BackgroundColour(ConsoleColor colour);
        void ForegroundColour(ConsoleColor colour);
    }

    public class ConsoleWrapper : IConsole
    {
        public void Write(string text)
        {
            Console.Write(text);
        }

        public void WriteLine(string text)
        {
            Console.WriteLine();
        }

        public void BackgroundColour(ConsoleColor colour)
        {
            Console.BackgroundColor = colour;
        }

        public void ForegroundColour(ConsoleColor colour)
        {
            Console.ForegroundColor = colour;
        }
    }
}