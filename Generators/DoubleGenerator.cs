using System;
using Faker.Generators.Interface;

namespace Faker.Generators.Primitive
{
    public class DoubleGenerator : IGenerator
    {
        public object Generate()
        {
            return Util.Util.GetRandom().NextDouble();
        }

        public Type GetGenerationType()
        {
            return typeof(double);
        }
    }
}