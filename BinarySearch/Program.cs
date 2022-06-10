class BinarySearch
{
    public static int Search(int[] array, int value)
    {
        int left = 0;
        int right = array.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (array[mid] == value)
            {
                return mid;
            }
            else if (array[mid] < value)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return -1;
    }

    //public static void Main()
    //{
    //    //int[] array = new int[1024];

    //    //for (var i = 0; i < 1024; i++)
    //    //{
    //    //    array[i] = i;
    //    //}
    //    //int[] array = { -1, 0, 3, 5, 9, 12 };
    //    //int value = 9;
    //    //int index = Search(array, value);
    //    //if (index == -1)
    //    //{
    //    //    Console.WriteLine("{0} not found", value);
    //    //}
    //    //else
    //    //{
    //    //    Console.WriteLine("{0} found at index {1}", value, index);
    //    //}
    //}
}