using System;

namespace BingoEngine
{
    public static class RandomNumber
    {
        private static readonly Random rand = new Random();
        public static int GetRandomNumber(int min, int max)
        {
            lock (rand)
            {
                return rand.Next(min, max);
            }
        }
    }
}
