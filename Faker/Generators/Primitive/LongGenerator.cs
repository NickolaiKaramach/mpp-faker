using System;
using Faker.Generators.Interface;

namespace Faker.Generators.Primitive
{
    public class LongGenerator : IGenerator
    {
        public object Generate()
        {
            return (long) (Util.Util.GetRandom().NextDouble() * long.MaxValue);
        }

        public Type GetGenerationType()
        {
            return typeof(long);
        }
    }
}