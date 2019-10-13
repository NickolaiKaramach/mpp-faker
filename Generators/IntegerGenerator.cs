using System;

namespace Generators
{
    public class IntegerGenerator : IGenerator
    {
        public object Generate()
        {
            return Util.GetRandom().Next(1, int.MaxValue);
        }

        public Type GetGenerationType()
        {
            return typeof(int);
        }
    }
}