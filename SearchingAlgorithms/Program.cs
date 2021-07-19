using System;

namespace SearchingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(ReturnBinarySearchIndex(numbers, 4));
        }
        //Binary search return index Average performance  O(log(n))

        static int ReturnBinarySearchIndex(int[] numbers, int searchNumber)
        {
            var startIndex = 0;
            var endIndex = numbers.Length - 1;
            while (startIndex <= endIndex)
            {
                var midle = (startIndex + endIndex) / 2;
                if (numbers[midle] == searchNumber)
                {
                    return midle;
                }

                if (searchNumber > numbers[midle])
                    startIndex = midle + 1;
                else
                    endIndex = midle - 1;
            }
            return -1;
        }

    }
}
