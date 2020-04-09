using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    class Program
    {
        static void Main(string[] args)
        {
            TestPermMissingElem();
        }

        static void TestBinaryGap()
        {
            int testNumber = 1;
            Console.WriteLine("Binary gap for " + testNumber + " is " + BinaryGap.GetBinaryGap(testNumber));

            testNumber = int.MaxValue;
            Console.WriteLine("Binary gap for " + testNumber + " is " + BinaryGap.GetBinaryGap(testNumber));

            testNumber = -1;
            try
            {
                Console.WriteLine("Binary gap for " + testNumber + " is " + BinaryGap.GetBinaryGap(testNumber));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("-1 is out of bounds and will therefore fail.");
            }

            do
            {
                Console.WriteLine("Type out an int you want to try.");

                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out testNumber))
                {

                    try
                    {
                        Console.WriteLine("Binary gap for " + testNumber + " is " + BinaryGap.GetBinaryGap(testNumber));
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine(testNumber + " is out of bounds and will therefore fail.");
                    }
                }
                else
                {
                    Console.WriteLine(userInput + " cannot be converted to an int. Please type a valid int.");
                }

                Console.WriteLine("Type anything and press enter to exit the loop. Otherwise press enter to continue testing.");
            } while (String.IsNullOrWhiteSpace(Console.ReadLine()))
                    ;

        }

        static void TestRotateIntArray()
        {
            int[] testArray = new int[] { 4, 3, 2, 1 };
            Console.WriteLine(String.Join(", ", CyclicRotation.RotateIntArray(testArray, 1)));
            Console.WriteLine(String.Join(", ", CyclicRotation.RotateIntArray(testArray, 2)));
            Console.WriteLine(String.Join(", ", CyclicRotation.RotateIntArray(testArray, 4)));
            Console.WriteLine(String.Join(", ", CyclicRotation.RotateIntArray(testArray, 8)));

            Console.ReadLine();
        }

        static void TestOddOccurrenceInArray()
        {
            int[] testArray = new int[] { 4, 3, 4, 3, 2 };
            Console.WriteLine(OddOccurrencesInArray.GetOddOccurrenceInArray(testArray));

            testArray = new int[] { 4, 3, 4, 3, 9 };
            Console.WriteLine(OddOccurrencesInArray.GetOddOccurrenceInArray(testArray));

            Console.ReadLine();
        }

        static void TestFrogJmp()
        {
            Console.WriteLine(FrogJmp.GetHops(1, 100000, 1));

            Console.ReadLine();
        }

        static void TestPermMissingElem()
        {
            int[] testArray = new int[] { 4, 3, 1, 5 };

            Console.WriteLine(PermMissingElem.GetMissingElementStartingWith1(testArray));

            testArray = new int[] { 4, 3, 1, 5, 2 };

            Console.WriteLine(PermMissingElem.GetMissingElementStartingWith1(testArray));

            testArray = new int[] { };

            Console.WriteLine(PermMissingElem.GetMissingElementStartingWith1(testArray));

            Console.ReadLine();
        }
    }
}
