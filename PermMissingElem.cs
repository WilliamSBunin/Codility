using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    //Find the missing element in a given permutation.
    class PermMissingElem
    {
        public static int GetMissingElement(int[] array)
        {
            List<int> sortedArray = new List<int>(array);

            sortedArray.Sort();

            for (int i = 0; i < sortedArray.Count; i++)
            {
                if (i + sortedArray[0] != sortedArray[i])
                {
                    return i + sortedArray[0];
                }
            }

            return sortedArray[sortedArray.Count - 1] + 1;
        }

        public static int GetMissingElementStartingWith1(int[] array)
        {
            List<int> sortedArray = new List<int>(array);

            sortedArray.Sort();

            if (sortedArray.Count == 0 || sortedArray[0] != 1)
            {
                return 1;
            }

            for (int i = 0; i < sortedArray.Count; i++)
            {
                if (i + sortedArray[0] != sortedArray[i])
                {
                    return i + sortedArray[0];
                }
            }

            return sortedArray[sortedArray.Count - 1] + 1;
        }
    }
}
