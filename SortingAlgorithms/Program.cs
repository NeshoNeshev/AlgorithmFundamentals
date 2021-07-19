using System;
using System.Linq;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            var numders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //SelectionSort(numders);
            //BubbleSort(numders);
            InsertionSort(numders);
            Console.WriteLine(string.Join("", numders));
        }
        public static void SelectionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                var minIndex = i;
                var minNumber = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < minNumber)
                    {
                        minNumber = numbers[j];
                        minIndex = j;
                    }
                }

                Swap(numbers, i, minIndex);
            }
        }
        public static void BubbleSort(int[] numbers)
        {

            var isSorted = false;
            var i = 0;
            while (!isSorted)
            {
                isSorted = true;
                for (int j = 1; j < numbers.Length - i; j++)
                {
                    if (numbers[j - 1] > numbers[j])
                    {
                        isSorted = false;
                        Swap(numbers, j - 1, j);
                    }
                }
                i += 1;
            }
        }
        public static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                var j = i;
                while (j > 0 && arr[j] < arr[j - 1])
                {
                    Swap(arr, j, j - 1);
                    j--;
                }
            }
        }
        private static void Swap(int[] numbers, int first, int second)
        {
            var temp = numbers[first];
            numbers[first] = numbers[second];
            numbers[second] = temp;
        }
    }

}
