/*
 The maximum sum subarray problem consists in finding the maximum sum of a contiguous subsequence in an array or list of integers:

maxSequence [-2, 1, -3, 4, -1, 2, 1, -5, 4]
-- should be 6: [4, -1, 2, 1]
Easy case is when the list is made up of only positive numbers and the maximum sum is the sum of the whole array. If the list is made up of only negative numbers, return 0 instead.

Empty list is considered to have zero greatest sum. Note that the empty list or array is also a valid sublist/subarray.
 */
using System;
using System.Linq;

namespace Maximum_subarray_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.MaxSequence(new int[] {-2, 1, -3, 4, -1, 2, 1, -5, 4}));
            //Console.WriteLine(Kata.MaxSequence(new int[] {}));
        }
    }

    public static class Kata
    {
        public static int MaxSequence(int[] arr)
        {
            if (arr.Length == 0)
                return 0;

            int dim = arr.Length * (arr.Length + 1) / 2;
            int[] sums = new int[dim];
            int k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length - i+1; j++)
                {
                    sums[i+j-1] = arr.Skip(i).Take(j).Sum();
                    k++;
                }
            }
            return sums.Max()<0?0:sums.Max();
        }
    }
}
