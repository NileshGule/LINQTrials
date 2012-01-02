using System;
using System.Collections.Generic;
using System.Linq;

namespace ConversionOperators
{
    internal class ToArray
    {
        public ToArray()
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

            var sortedArray = sortedNumbers.ToArray();

            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.WriteLine(sortedArray[i]);
            }

        }
    }
}