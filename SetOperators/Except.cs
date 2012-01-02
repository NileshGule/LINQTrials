using System;
using System.Collections.Generic;
using System.Linq;

namespace SetOperators
{
    internal class Except
    {
        public Except()
        {
            IList<int> firstList = new List<int>
                                       {
                                           1,
                                           2,
                                           3,
                                           4,
                                           5
                                       };

            IList<int> secondList = new List<int>
                                        {
                                            1,
                                            3,
                                            5,
                                            7
                                        };

            var exceptNumbers = firstList.Except(secondList);

            Console.WriteLine("Common numbers between two lists");

            foreach (int exceptNumber in exceptNumbers)
            {
                Console.WriteLine(exceptNumber);
            }
        }
    }
}