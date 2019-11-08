using System;
using Faker.Generators.Interface;

namespace Faker.Generators.Generic.Factory
{
    public class GenericGeneratorFactory : IGenericGeneratorFactory
    {
        public IGenerator GetGenerator(Type[] genericType)
        {
            var type = typeof(ListGenerator<>);
            var generatorType = type.MakeGenericType(genericType[0]);
            return (IGenerator) Activator.CreateInstance(generatorType);
        }
    }
}