using System;
using Faker.Generators.Interface;
// Hello world
namespace Faker.Generators.Primitive
{
    public class BooleanGenerator : IGenerator
    {
        public object Generate()
        {
            return Util.Util.GetRandom().Next(0, 1) == 1;
        }

        public Type GetGenerationType()
        {
            return typeof(bool);
        }
    }
}