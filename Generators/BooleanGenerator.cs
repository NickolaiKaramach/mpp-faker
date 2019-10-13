using System;

namespace Generators
{
    public class BooleanGenerator : IGenerator
    {
        public object Generate()
        {
            return Util.GetRandom().Next(0, 1) == 1;
        }

        public Type GetGenerationType()
        {
            return typeof(bool);
        }
    }
}