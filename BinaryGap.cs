using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    //Find longest sequence of zeros in binary representation of an integer.
    class BinaryGap
    {
        public static int GetBinaryGap(int number)
        {
            if (number < 1)
            {
                throw new ArgumentOutOfRangeException("number", number, "number cannot be less than 1");
            }

            string numberAsBinary = GetBinary(number);

            int maxBinaryGroup = 0;
            int currentBinaryGroup = 0;

            foreach (char digit in numberAsBinary)
            {
                if (digit.Equals('1'))
                {
                    if (maxBinaryGroup < currentBinaryGroup)
                    {
                        maxBinaryGroup = currentBinaryGroup;
                    }

                    currentBinaryGroup = 0;
                }
                else
                {
                    currentBinaryGroup++;
                }
            }

            return maxBinaryGroup;
        }

        public static string GetBinary(int number)
        {
            StringBuilder binaryNumber = new StringBuilder(String.Empty);

            int numberDivided = number / 2;

            if (numberDivided > 1)
            {
                string previousDigits = GetBinary(numberDivided);
                binaryNumber.Append(previousDigits);
            }
            else
            {
                binaryNumber.Append("1");
            }

            binaryNumber.Append(number % 2);

            return binaryNumber.ToString();
        }
    }
}
