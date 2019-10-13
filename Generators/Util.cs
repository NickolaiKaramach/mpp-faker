using System;

namespace Generators
{
    public static class Util
    {
        private static readonly Random Random = new Random((int) DateTime.Now.Ticks);
        
        public static Random GetRandom()
        {
            return Random;
        }
    }
}