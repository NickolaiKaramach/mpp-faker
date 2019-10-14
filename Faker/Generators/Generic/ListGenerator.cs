using System;
using System.Collections.Generic;
using Faker.Generators.Interface;

namespace Faker.Generators.Generic
{
    public class ListGenerator<T> : IGenericGenerator
    {
        public object Generate()
        {
            var list = new List<T>();

            var size = Util.Util.GetRandom().Next(1, 15);

            var faker = new Faker();
            for (var i = 0; i < size; i++)
            {
                var item = (T) faker.Create<T>();
                list.Add(item);
            }

            return list;
        }

        public Type GetGenerationType()
        {
            return typeof(List<T>);
        }
    }
}