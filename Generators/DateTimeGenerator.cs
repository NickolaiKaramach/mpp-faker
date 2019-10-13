using System;

namespace Generators
{
    public class DateTimeGenerator : IGenerator
    {
        public object Generate()
        {
            return DateTime.Now.AddDays(Util.GetRandom().Next(1000));
        }

        public Type GetGenerationType()
        {
            return typeof(DateTime);
        }
    }
}