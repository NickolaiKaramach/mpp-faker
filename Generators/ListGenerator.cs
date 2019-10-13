using System;
using System.Collections.Generic;

namespace Generators
{
    public class ListGenerator<T> : IGenerator
    {
        public object Generate()
        {
            var list = new List<T>();
            
            var size = Util.GetRandom().Next(1, 15);
            
            var faker = new Faker();
            for (var i = 0; i < size; i++)
            {
                var item = (T)faker.Create<T>();
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