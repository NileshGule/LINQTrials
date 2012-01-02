using System;
using System.Collections.Generic;
using System.Linq;

namespace AggregateOperators
{
    internal class SimpleCount
    {
        public SimpleCount()
        {
            IList<int> numbers = new List<int>
                                    {
                                        1,
                                        2,
                                        3,
                                        4,
                                        5
                                    };

            Console.WriteLine("Numbers in the list using Count property = {0}", numbers.Count);
            Console.WriteLine("Numbers in the list using Count function = {0}", numbers.ToArray().Count());

        }
    }
}