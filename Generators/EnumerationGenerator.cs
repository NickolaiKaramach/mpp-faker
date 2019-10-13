using System;

namespace Generators
{
    public class EnumerationGenerator<T> : IGenerator
    {
        public object Generate()
        {
            Type type = typeof(T);
            var values = Enum.GetValues(type);
            
            return values.GetValue(Util.GetRandom().Next(1, values.Length));
        }

        public Type GetGenerationType()
        {
            return typeof(Enum);
        }
    }
}