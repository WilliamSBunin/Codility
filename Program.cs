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
            TestBinaryGap();
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
    }
}
