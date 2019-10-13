using System;

namespace Generators
{
    class ArrayGenerator<T> : IGenerator
    {
        public object Generate()
        {
            var type = typeof(T);

            var arrLength = Util.GetRandom().Next(1, 15);
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