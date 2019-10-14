using System;
using Faker.Generators.Interface;

namespace Faker.Generators.Generic.Factory
{
    internal class EnumerationGeneratorFactory : IGenericGeneratorFactory
    {
        public IGenerator GetGenerator(Type[] genericType)
        {
            var enumGenericGeneratorType = typeof(EnumerationGenerator<>);
            var enumGeneratorType = enumGenericGeneratorType.MakeGenericType(genericType[0]);

            return (IGenerator) Activator.CreateInstance(enumGeneratorType);
        }
    }
}