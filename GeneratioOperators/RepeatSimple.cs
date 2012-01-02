using System;
using System.Collections.Generic;
using System.Linq;

namespace GeneratioOperators
{
    internal class RepeatSimple
    {
        public RepeatSimple()
        {
            IEnumerable<int> repeatedNumber = Enumerable.Repeat(5, 10);

            foreach (int number in repeatedNumber)
            {
                Console.WriteLine(number);
            }
        }
    }
}