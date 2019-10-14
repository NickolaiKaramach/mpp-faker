using System;
using Faker.Generators.Interface;

namespace Faker.Generators.Generic
{
    public class EnumerationGenerator<T> : IGenericGenerator
    {
        public object Generate()
        {
            var type = typeof(T);
            var values = Enum.GetValues(type);

            return values.GetValue(Util.Util.GetRandom().Next(1, values.Length));
        }

        public Type GetGenerationType()
        {
            return typeof(Enum);
        }
    }
}