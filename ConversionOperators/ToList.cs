using System;
using System.Collections.Generic;
using System.Linq;

namespace ConversionOperators
{
    internal class ToList
    {
        public ToList()
        {
            IList<int> numbers = new List<int>
                                    {
                                        1,
                                        2,
                                        5,
                                        3,
                                        8,
                                        4
                                    };

            var sortedNumbers = from n in numbers
                                orderby n
                                select n;

            var sortedArray = sortedNumbers.ToList();

            foreach (int sortedNumebr in sortedArray)
            {
                Console.WriteLine(sortedNumebr);
            }
        }
    }
}