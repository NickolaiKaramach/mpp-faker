using System;
using Faker.Generators.Interface;

namespace Faker.Generators.Primitive
{
    public class IntegerGenerator : IGenerator
    {
        public object Generate()
        {
            return Util.Util.GetRandom().Next(1, int.MaxValue);
        }

        public Type GetGenerationType()
        {
            return typeof(int);
        }
    }
}