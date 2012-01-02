using System;
using System.Collections.Generic;
using System.Linq;

namespace Quantifiers
{
    internal class AllSimple
    {
        public AllSimple()
        {
            IList<int> multiplesOfFive = new List<int>
                                            {
                                                5,
                                                10,
                                                15,
                                                20
                                            };

            bool allDivisibleByFive = multiplesOfFive.All(n => n%5 == 0);

            Console.WriteLine("Are all numbers divisible by 5 : {0}", allDivisibleByFive);
        }
    }
}