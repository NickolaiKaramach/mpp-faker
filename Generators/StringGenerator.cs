using System;
using System.Text;

namespace Generators
{
    public class StringGenerator : IGenerator
    {
        private static readonly Random Random = Util.GetRandom();

        private static readonly String _dictionary =
            "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";

        public object Generate()
        {
            var builder = new StringBuilder();

            var size = Random.Next(1, 80);
            for (var i = 0; i < size; i++)
            {
                int indexInDictionary = Random.Next(0, _dictionary.Length - 1);
                
                var symbol = _dictionary[indexInDictionary];
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