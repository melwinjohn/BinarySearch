using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    internal class MergeSort
    {
        public static int[] Sort(int[] array)
        {
            if(array.Count() < 2)
            {
                return array;
            }

            var middleIndex = array.Count() / 2;
            var left = array.Take(middleIndex).ToArray();
            var right = array.Skip(middleIndex).ToArray();

            return Merge(Sort(left), Sort(right));
        }


        private static int[] Merge(int[] leftarray, int[] rightarray)
        {
            List<int> resultArray = new List<int>();
            var lftIndex = 0;
            var rgtIndex = 0;

            while (lftIndex < leftarray.Count() && rgtIndex < rightarray.Count())
            {
                if (leftarray[lftIndex] < rightarray[rgtIndex])
                {
                    resultArray.Add(leftarray[lftIndex]);
                    lftIndex++;
                }
                else
                {
                    resultArray.Add(rightarray[rgtIndex]);
                    rgtIndex++;
                }
                

            }
            return resultArray.Concat(leftarray.Skip(lftIndex)).Concat(rightarray.Skip(rgtIndex)).ToArray();
        }
        
        //public static void Main(string[] args)
        //{
        //    int[] array = { 10, 22, 13, 4, 15, 6, 17, 8, 29, 50,78 };
        //    array = Sort(array);
        //    foreach (int i in array)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
    }
}
