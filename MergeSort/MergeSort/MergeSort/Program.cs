using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] SortedArr= new int[] { 20, 45, 33, 15, 8, 66, 32, 50, 85, 12 };
            MergeSort(SortedArr, 0, SortedArr.Length - 1);

            foreach (var c in SortedArr)
            {
                Console.WriteLine(c);
            }
            Console.Read();
        }

        //resource: https://gist.github.com/pmgeorg/9122984
        static void Merge(int[] toSort, int left, int middle, int right)
        {
            int LPoint = left;
            int RPoint = middle + 1;
            int[] temp = new int[(right - left) + 1];
            int tempPointer = 0;

            while (LPoint <= middle && RPoint <= right)
            {
                if (toSort[LPoint] < toSort[RPoint])
                {
                    temp[tempPointer++] = toSort[LPoint++];
                }
                else
                {
                    temp[tempPointer++] = toSort[RPoint++];
                }
            }

            while (LPoint <= middle)
            {
                temp[tempPointer++] = toSort[LPoint++];
            }

            while (RPoint <= right)
            {
                temp[tempPointer++] = toSort[RPoint++];
            }

            for (int i = 0; i < temp.Length; i++)
            {
                toSort[left + i] = temp[i];
            }
        }

        static void MergeSort(int[] toSort, int left, int right)
        {
            if (left < right)
            {
                int middle = (left / 2) + (right / 2);
                MergeSort(toSort, left, middle);
                MergeSort(toSort, middle + 1, right);
                Merge(toSort, left, middle, right);
            }
        }
    }
}
