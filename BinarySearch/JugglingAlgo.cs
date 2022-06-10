using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JugglingAlgo
{
    internal class JugglingAlgo
    {
        private static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
            var n = array.Length;
            var d = 3;
            var x = leftRotate(array, d, n);
            Console.WriteLine(x);
        }

        public static int gcd(int a, int b)
        {
            if (b == 0)
                return a;
            return gcd(b, a % b);
        }

        public static int[] leftRotate(int[] arr, int d, int n)
        {
            d = d % n;
            int g = gcd(d, n);
            for (int i = 0; i < g; i++)
            {
                int temp = arr[i];
                int j = i;
                while(true)
                {
                    int k = j + d;
                    if (k >= n)
                        k = k - n;

                    if (k == i)
                        break;

                    arr[j] = arr[k];
                    j = k;
                }
                arr[j] = temp;
            }
            return arr;
        }
    
    }
}
