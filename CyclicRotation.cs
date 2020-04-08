using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    //Rotate an array to the right by a given number of steps.
    class CyclicRotation
    {
        public static int[] RotateIntArray(int[] array, int rotateAmount)
        {
            int[] rotatedArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                rotatedArray[(i + rotateAmount) % array.Length] = array[i];
            }

            return rotatedArray;
        }
    }
}
