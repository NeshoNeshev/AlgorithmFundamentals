using System;
using System.IO.MemoryMappedFiles;
using System.Linq;

namespace AdvancedSortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //QuickSort(numbers, 0, numbers.Length-1);
           var sorted= MergeSort(numbers);
            Console.WriteLine(string.Join(" ", sorted));
        }
        public static void QuickSort(
            int[] array, int startIdx, int endIdx)
        {
            if (startIdx >= endIdx)
                return;
            var pivotIdx = startIdx;
            var leftIdx = startIdx + 1;
            var rightIdx = endIdx;
            while (leftIdx <= rightIdx)
            {
                if (array[leftIdx] > array[pivotIdx] &&
                    array[rightIdx] < array[pivotIdx])
                {
                    Swap(array, leftIdx, rightIdx);
                }

                if (array[leftIdx] <= array[pivotIdx])
                {
                    leftIdx += 1;
                }

                if (array[rightIdx] >= array[pivotIdx])
                {
                    rightIdx -= 1;
                }

            }
            Swap(array, pivotIdx, rightIdx);

            var isLeftSubArraysSmaller =
                rightIdx - 1 - startIdx < endIdx - (rightIdx + 1);
            if (isLeftSubArraysSmaller)
            {
                QuickSort(array, startIdx, rightIdx - 1);
                QuickSort(array, rightIdx + 1, endIdx);
            }
            else
            {
                QuickSort(array, rightIdx + 1, endIdx);
                QuickSort(array, startIdx, rightIdx - 1);
            }
        }

        private static int[] MergeSort(int[] numbers)
        {
            if (numbers.Length<=1)
            {
                return numbers;
            }
            var left = numbers.Take(numbers.Length / 2).ToArray();
            var right = numbers.Skip(numbers.Length / 2).ToArray();
            return Merge(MergeSort(left), MergeSort(right));
        }

        private static int[] Merge(int[] left, int[] righInts)
        {
            var merget = new int[left.Length + righInts.Length];

            var mergedIdx = 0;
            var leftIdx = 0;
            var rightIdx = 0;
            while (leftIdx < left.Length && rightIdx < righInts.Length)
            {
                if (left[leftIdx] < righInts[rightIdx])
                {
                    merget[mergedIdx] = left[leftIdx];
                    leftIdx += 1;
                }
                else
                {
                    merget[mergedIdx] = righInts[rightIdx];
                    rightIdx += 1;
                }

                mergedIdx += 1;
            }
            while (leftIdx < left.Length)
            {
                merget[mergedIdx] = left[leftIdx];
                leftIdx += 1;

                mergedIdx += 1;
            }
            while (rightIdx < righInts.Length)
            {
                merget[mergedIdx] = righInts[rightIdx];
                rightIdx += 1;

                mergedIdx += 1;
            }

            return merget;
        }

        private static void Swap(int[] numbers, int first, int second)
        {
            var temp = numbers[first];
            numbers[first] = numbers[second];
            numbers[second] = temp;
        }
    }
}
