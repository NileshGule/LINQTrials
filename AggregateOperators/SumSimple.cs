using System;
using System.Collections.Generic;
using System.Linq;

namespace AggregateOperators
{
    internal class SumSimple
    {
        public SumSimple()
        {
            IEnumerable<int> fiveTenTimes = Enumerable.Repeat(5, 10);

            Console.WriteLine("Sum = {0}", fiveTenTimes.Sum());
        }
    }
}