using System;

namespace Generators
{
    public interface IGenerator
    {
        Object Generate();

        Type GetGenerationType();
    }
}