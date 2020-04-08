using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    class OddOccurrencesInArray
    {
        public static int GetOddOccurrenceInArray(int[] array)
        {
            List<int> sortedArray = new List<int>(array);

            sortedArray.Sort();

            int lastNumber = 0;
            int lastNumberCounter = 2;

            foreach (int number in sortedArray)
            {
                if (number == lastNumber)
                {
                    lastNumberCounter++;
                }
                else
                {
                    if (lastNumberCounter % 2 != 0)
                    {
                        return lastNumber;
                    }

                    lastNumber = number;
                    lastNumberCounter = 1;
                }
            }

            return lastNumber;
        }
    }
}
