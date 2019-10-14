using System;

namespace Faker.Generators.Interface
{
    public interface IGenerator
    {
        object Generate();

        Type GetGenerationType();
    }
}