using System;
using Faker.Generators.Interface;

namespace Faker.Generators.Generic.Factory
{
    public class ListGeneratorFactory : IGenericGeneratorFactory
    {
        public IGenerator GetGenerator(Type[] genericType)
        {
            var listGenericGeneratorType = typeof(ListGenerator<>);
            var listGeneratorType = listGenericGeneratorType.MakeGenericType(genericType[0]);
            return (IGenerator) Activator.CreateInstance(listGeneratorType);
        }
    }
}