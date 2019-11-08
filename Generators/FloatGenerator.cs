using System;
using Faker.Generators.Interface;

namespace Faker.Generators.Primitive
{
    public class FloatGenerator : IGenerator
    {
        private static readonly Random Random = Util.Util.GetRandom();

        public object Generate()
        {
            var mantissa = Random.NextDouble() * 2.0 - 1.0;
            var exponent = Math.Pow(2.0, Random.Next(-126, 128));

            return (float) (mantissa * exponent);
        }

        public Type GetGenerationType()
        {
            return typeof(float);
        }
    }
}