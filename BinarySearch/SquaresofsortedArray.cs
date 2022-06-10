using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaresOfSortedArray
{
    internal class SquaresofsortedArray
    {
        //public static void Main(string[] args)
        //{
        //    var nums = new int[] { -4, -1, 0, 3, 10 };
        //    int[] sortedArray = sortedSquaresSimplified(nums);
        //    for (int i = 0; i < sortedArray.Length; i++)
        //    {
        //        Console.WriteLine(sortedArray[i] + " ");
        //    }
            

        //}

        public static int[] sortedSquaresSimplified(int[] nums)
        {
            var n = nums.Length;
            int[] array = new int[n];
            int highestSquareIDx = n - 1;

            int left = 0;
            int right = n - 1;

            while (left <= right)
            {
                int leftSquare = nums[left] * nums[left];
                int rightSquare = nums[right] * nums[right];

                if (leftSquare > rightSquare)
                {
                    array[highestSquareIDx] = leftSquare;
                    left++;
                }
                else
                {
                    array[highestSquareIDx] = rightSquare;
                    right--;
                }
                highestSquareIDx--;
            }
            return array;

        }



    }
}
