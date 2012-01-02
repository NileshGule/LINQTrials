using System;
using System.Collections.Generic;
using System.Linq;

namespace SetOperators
{
    internal class Intersect1
    {
        public Intersect1()
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

            var commonNumbers = firstList.Intersect(secondList);

            Console.WriteLine("Common numbers between two lists");

            foreach (int commonNumber in commonNumbers)
            {
                Console.WriteLine(commonNumber);
            }
        }
    }
}