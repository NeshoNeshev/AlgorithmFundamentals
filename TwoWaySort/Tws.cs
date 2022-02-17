
using System;

namespace Partition
{
    public class Tws
    {

        public void SortTwoWay(int[] arr, int n)
        {

            int leftIndex = 0, rightIndex = n - 1;

            int count = 0;

            while (leftIndex < rightIndex)
            {
                while (arr[leftIndex] % 2 != 0)
                {
                    leftIndex++;
                    count++;
                }

                while (arr[rightIndex] % 2 == 0 && leftIndex < rightIndex)
                    rightIndex--;

                if (leftIndex < rightIndex)
                {

                    int temp = arr[leftIndex];
                    arr[leftIndex] = arr[rightIndex];
                    arr[rightIndex] = temp;
                }
            }

            Array.Sort(arr, 0, count);
            Array.Reverse(arr, 0, count);

            Array.Sort(arr, count, n - count);
        }
    }
}
