using System;
using Faker.Generators.Interface;

namespace UnitTests
{
    public class FooStringGenerator : IGenerator
    {
        public object Generate()
        {
            return "TEST";
        }

        public Type GetGenerationType()
        {
            return typeof(string);
        }
    }
}