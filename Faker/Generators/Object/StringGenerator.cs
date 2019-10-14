using System;
using System.Text;
using Faker.Generators.Interface;

namespace Faker.Generators.Object
{
    public class StringGenerator : IGenerator
    {
        private static readonly Random Random = Util.Util.GetRandom();

        private const string Dictionary = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";

        public object Generate()
        {
            var builder = new StringBuilder();

            var size = Random.Next(1, 80);
            for (var i = 0; i < size; i++)
            {
                var indexInDictionary = Random.Next(0, Dictionary.Length - 1);

                var symbol = Dictionary[indexInDictionary];
                builder.Append(symbol);
            }

            return builder.ToString();
        }

        public Type GetGenerationType()
        {
            return typeof(string);
        }
    }
}