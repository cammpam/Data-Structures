using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadixSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] originalArr = new int[] { 14, 47, 32, 37, 30, 4, 7 };
            Console.WriteLine("Original Array: ");

            foreach (var c in originalArr)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();

            Console.WriteLine("Radix Sort Array: ");
            foreach (var item in RadixSort(originalArr))
            {
                Console.WriteLine(item);
            }


            Console.Read();
        }

        // math operation for bucket selection
        static int DigitMath(int power, int data)
        {
            return (int)((data % Math.Pow(10, power + 1)) / Math.Pow(10, power));
        }

        //first sort implementation
        static List<int>[] Buckets(int[] toSort)
        {
            List<int>[] newBuckets = new List<int>[10];
            for (int i = 0; i < newBuckets.Length; i++)
            {
                newBuckets[i] = new List<int>();
            }
            for (int i = 0; i < toSort.Length; i++)
            {
                newBuckets[DigitMath(0, toSort[i])].Add(toSort[i]);
            }
            return newBuckets;
        }

        
        static List<int>[] SortedBuckets(int power, List<int>[] bucketSort)
        {
            List<int>[] newBuckets = new List<int>[10];
            for (int i = 0; i < newBuckets.Length; i++)
            {
                newBuckets[i] = new List<int>();
            }
            for (int i = 0; i < bucketSort.Length; i++)
            {
                if (bucketSort[i].Count > 0)
                {
                    for (int j = 0; j < bucketSort[i].Count; j++)
                    {
                        newBuckets[DigitMath(power, bucketSort[i][j])].Add(bucketSort[i][j]);
                    }
                }
            }
            return newBuckets;
        }

        //Converts a bucket into the final array
        static int[] LastArray(List<int>[] bucketToSort, int originalArrayLength)
        {

            int[] returnArray = new int[originalArrayLength];
            int addAtIndex = 0;
            for (int i = 0; i < bucketToSort.Length; i++)
            {
                if (bucketToSort[i].Count > 0)
                {
                    for (int j = 0; j < bucketToSort[i].Count; j++)
                    {
                        returnArray[addAtIndex] = bucketToSort[i][j];
                        addAtIndex++;
                    }
                }
            }
            return returnArray;
        }

        //Finds the largest number in the Array
        static int GetMax(int[] theArray)
        {
            int max = 0;
            int checkLength;

            for (int i = 0; i < theArray.Length; i++)
            {
                checkLength = theArray[i].ToString().Length;
                if (checkLength > max)
                {
                    max = checkLength;
                }
            }

            return max;
        }

        //Sort method
        static int[] RadixSort(int[] toSort)
        {
            List<int>[] SortedBucket = Buckets(toSort);
            for (int i = 1; i < GetMax(toSort); i++)
            {
                SortedBucket = SortedBuckets(i, SortedBucket);
            }

            int[] returnArray = LastArray(SortedBucket, toSort.Length);

            return returnArray;
        }

    }
}
