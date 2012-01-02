using System;
using System.Collections.Generic;
using System.Linq;

namespace Quantifiers
{
    internal class AnySimple
    {
        public AnySimple()
        {
            IEnumerable<int> rangeOfNumbers = Enumerable.Range(5, 20);

            var divisibleByThree = rangeOfNumbers.Any(n => n%3 == 0);

            Console.WriteLine("Any number divisible by 3 in the range = {0}", divisibleByThree);
        }
    }
}