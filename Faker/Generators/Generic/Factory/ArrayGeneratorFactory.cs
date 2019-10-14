using System;
using Faker.Generators.Interface;

namespace Faker.Generators.Generic.Factory
{
    internal class ArrayGeneratorFactory : IGenericGeneratorFactory
    {
        public IGenerator GetGenerator(Type[] genericType)
        {
            var arrayGenericGeneratorType = typeof(ArrayGenerator<>);
            var arrayGeneratorType = arrayGenericGeneratorType.MakeGenericType(genericType);
            return (IGenerator) Activator.CreateInstance(arrayGeneratorType);
        }
    }
}