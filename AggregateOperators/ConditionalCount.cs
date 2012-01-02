using System;
using System.Collections.Generic;
using System.Linq;

namespace AggregateOperators
{
    internal class ConditionalCount
    {
        public ConditionalCount()
        {
            IList<int> numbers = new List<int>
                            {
                                1,
                                2,
                                3,
                                4,
                                5
                            };

            var oddNumbers = numbers.ToArray().Count(n => n%2 == 0);

            Console.WriteLine("Number of odds = {0}", oddNumbers);
        }
    }
}