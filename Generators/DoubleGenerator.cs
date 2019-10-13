using System;

namespace Generators
{
    public class DoubleGenerator : IGenerator
    {
        public object Generate()
        {
            return Util.GetRandom().NextDouble();
        }

        public Type GetGenerationType()
        {
            return typeof(double);
        }
    }
}