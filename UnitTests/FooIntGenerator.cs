using System;
using Faker.Generators.Interface;

namespace UnitTests
{
    internal class FooIntGenerator : IGenerator
    {
        public object Generate()
        {
            return 123;
        }

        public Type GetGenerationType()
        {
            return typeof(int);
        }
    }
}