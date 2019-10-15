using System;

namespace Faker.Generators.Util
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