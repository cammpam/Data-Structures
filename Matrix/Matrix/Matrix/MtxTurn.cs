using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class MtxTurn
    {
        // initiate matrix
        int[,] mtx;
        // storing last index of n
        static int prevIndex;
        // constructor to turn matrix
        public MtxTurn(int n)
        {
            int k = 11;
            prevIndex = n - 1;
            mtx = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mtx[i, j] = k;
                    k++;
                }
            }
        }
        public void Rotator()
        {
            // x is the lower bounds of the current round of rotation
            int x = 0;
            // y is the upper bounds of the current round of rotation
            int y = prevIndex;
            // l keeps track of how many rounds of rotation are needed
            for (int l = 0; l < prevIndex / 2; l++)
            {
                // k is the upper bounds of the current digit of rotation
                int k = y;
                // i is the lower bounds of the current digit of rotation
                for (int i = x; i < y; i++)
                {
                    // store top left in a temp variable
                    int temp = mtx[x, i];
                    // replace top left with bottom left
                    mtx[x, i] = mtx[k, x];
                    // replace bottom left with bottom right
                    mtx[k, x] = mtx[y, k];
                    // replace bottom right with top right
                    mtx[y, k] = mtx[i, y];
                    // replace top right with the temp we saved from top left initially
                    mtx[i, y] = temp;
                    // decrementing this and incrementing i moves over to the next digit
                    k--;
                }
                // these move us a row deeper into the matrix
                x++;
                y--;
            }
        }
        public void Print()
        {
            for (int d = 0; d <= prevIndex; d++)
            {
                for (int f = 0; f <= prevIndex; f++)
                {
                    Console.Write($"{mtx[d, f]}, ");
                }
                Console.WriteLine();
            }
        }
    }
}
