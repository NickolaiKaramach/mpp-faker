using System;
using Faker.Generators.Interface;

namespace Faker.Generators.Object
{
    public class DateTimeGenerator : IGenerator
    {
        public object Generate()
        {
            return DateTime.Now.AddDays(Util.Util.GetRandom().Next(1000));
        }

        public Type GetGenerationType()
        {
            return typeof(DateTime);
        }
    }
}