using System;
using System.Linq;

namespace GeneratioOperators
{
    internal class RangeSimple
    {
        public RangeSimple()
        {
            var numbers = from n in Enumerable.Range(10, 25)
                          select n;

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}