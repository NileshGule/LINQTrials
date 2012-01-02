using System;
using System.Collections.Generic;
using System.Linq;

namespace AggregateOperators
{
    internal class ProjectedSum
    {
        public ProjectedSum()
        {
            IList<int> numbers = new List<int>
                                    {
                                        1,
                                        2,
                                        3,
                                        4,
                                        5
                                    };

            var sumOfnumberPlusOne = numbers.Sum(n => n + 1);

            Console.WriteLine(sumOfnumberPlusOne);
        }
    }
}