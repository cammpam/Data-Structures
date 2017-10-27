using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 20, 30, 12, 23, 45, 2, 3, 14, 23, 60 };

            Console.WriteLine("Original array : ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            Quick_Sort(arr, 0, arr.Length - 1);

            Console.WriteLine();
            Console.WriteLine("Sorted array : ");

            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
            Console.Read();
        }
        private static void Quick_Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int piv = Partition(arr, low, high);

                if (piv > 1)
                {
                    Quick_Sort(arr, low, piv - 1);
                }
                if (piv + 1 < high)
                {
                    Quick_Sort(arr, piv + 1, high);
                }
            }

        }

        private static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[low];
            while (true)
            {

                while (arr[low] < pivot)
                {
                    low++;
                }

                while (arr[high] > pivot)
                {
                    high--;
                }

                if (low < high)
                {
                    if (arr[low] == arr[high]) return high;

                    int temp = arr[low];
                    arr[low] = arr[high];
                    arr[high] = temp;


                }
                else
                {
                    return high;
                }
            }
        }
    }
}
