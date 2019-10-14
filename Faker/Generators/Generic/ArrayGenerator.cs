using System;
using Faker.Generators.Interface;

namespace Faker.Generators.Generic
{
    internal class ArrayGenerator<T> : IGenericGenerator
    {
        public object Generate()
        {
            var type = typeof(T);

            var arrLength = Util.Util.GetRandom().Next(1, 15);
            var result = Array.CreateInstance(type, arrLength);

            var faker = new Faker();
            for (var i = 0; i < arrLength; i++)
            {
                var item = (T) faker.Create<T>();
                result.SetValue(item, i);
            }

            return result;
        }

        public Type GetGenerationType()
        {
            return typeof(Array);
        }
    }
}