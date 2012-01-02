using System;
using System.Collections.Generic;
using System.Linq;

namespace ConversionOperators
{
    internal class OfType
    {
        public OfType()
        {
            IList<object> objects = new List<object>
                                       {
                                           "Nilesh",
                                           1,
                                           2,
                                           3.5M
                                       };

            var onlyIntegers = objects.OfType<int>();

            foreach (int onlyInteger in onlyIntegers)
            {
                Console.WriteLine(onlyInteger);
            }
        }
    }
}