using System;

namespace Generators
{
    public class LongGenerator : IGenerator
    {
        public object Generate()
        {
            return (long) (Util.GetRandom().NextDouble() * long.MaxValue);
        }

        public Type GetGenerationType()
        {
            return typeof(long);
        }
    }
}