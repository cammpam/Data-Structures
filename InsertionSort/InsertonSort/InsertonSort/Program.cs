using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertonSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 7, 13, 5, 23, 76, 3, 6, 8, 100 };
            Console.WriteLine("Original Array: ");

            PrintArray(arr);

            Console.WriteLine("Insertion Array: ");

            int[] newArr = insertSort(arr);
            foreach (int c in newArr)
            {

                Console.WriteLine(c);
            }

            Console.ReadLine();

        }
        static int[] insertSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int exchange = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = exchange;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return arr;
        }

        public static void PrintArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }


    }
}
