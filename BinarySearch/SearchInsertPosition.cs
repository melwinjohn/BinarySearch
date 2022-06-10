using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInsert
{
    internal class SearchInsertPosition
    {
        public static int SearchInsert(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;
            var answer = -1;
            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                    answer = mid + 1;
                }
                else
                {
                    right = mid - 1;
                    answer = mid;
                }
            }
            return answer;

        }

        //public static void Main(string[] args)
        //{
        //    int[] array = { 1, 3, 5, 6 };
        //    int target = 2;
        //    var insert = SearchInsert(array, target);
        //    Console.WriteLine(insert);
        //}

    }
}
