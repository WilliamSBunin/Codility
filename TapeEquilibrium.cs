using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    //Minimize the value |(A[0] + ... + A[P-1]) - (A[P] + ... + A[N-1])|.
    class TapeEquilibrium
    {
        /*Given [3, 1, 2, 4, 3]
         * Total is 3 + 1 + 2 + 4 + 3 = 13 = T
         * So maybe we have 2 variables to represent T. T1 and T2.
         * If T = 13 and T1 = 3 then T2 = 10. So maybe we don't need T2.
         * T = 13; T1 = 3 --> T1 = 4 --> T1 = 6. 6 should be the answer. So floor(13/2)
         * 13 - 6 = 7... (13 - 6) - 6
         * 
         *Given [-1000, 1, 2]
         * What should happen?
         * Total is -997... So that breaks it... Hmmm... Negatives break it in general...
         * Can't base it on total... Wait... Why can't I just check each value. Compare difference and set min?
         * Difference should be 1003, 1001. So it should return 1002....
         */
        public static int GetTapeEquilibriumMinDifference(int[] array)
        {
            int total = 0;

            for (int i = 0; i < array.Length; i++)
            {
                total += array[i];
            }

            int tape1 = 0;
            int minDifference = int.MaxValue;

            for (int i = 0; i < array.Length - 1; i++)
            {
                tape1 += array[i];

                int difference = Math.Abs(total - tape1 - tape1);

                if (difference < minDifference)
                {
                    minDifference = difference;
                }
            }

            return minDifference;
        }
    }
}
