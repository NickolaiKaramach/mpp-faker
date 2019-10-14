using System;

namespace Faker.Generators.Interface
{
    public interface IGenericGeneratorFactory
    {
        IGenerator GetGenerator(Type[] genericType);
    }
}