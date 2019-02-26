using System;

namespace CheapWow.Helpers
{
    public interface IRandomGenerator
    {
        int GetRandomNumber(int min, int max);
    }

    public class RandomGenerator : IRandomGenerator
    {
        private static readonly Random _randomInstance = new Random();
        
        public int GetRandomNumber(int min, int max)
        {
            return _randomInstance.Next(min, max);
        }

    }
}
