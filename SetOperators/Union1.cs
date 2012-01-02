using System;
using System.Collections.Generic;
using System.Linq;

namespace SetOperators
{
    internal class Union1
    {
        public Union1()
        {
            IList<int> firstList = new List<int>
                           {
                               1,
                               3,
                               5,
                               4
                           };

            IList<int> secondList = new List<int>
                                        {
                                            2,
                                            3,
                                            4,
                                            6
                                        };

            var uniqueList = firstList.Union(secondList).OrderBy(n => n);

            Console.WriteLine("Unique list");

            foreach (int number in uniqueList)
            {
                Console.WriteLine(number);
            }
        }
    }
}