using System;

namespace FindExistingElementInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {{10, 20, 30, 40},
                {15, 25, 35, 45},
                {27, 29, 37, 48},
                {32, 33, 39, 50},
                {50, 60, 70, 80}};
            int searchNumber = int.Parse(Console.ReadLine() );
            Console.WriteLine(Search(matrix, 5, 4, searchNumber) ? "Yes" : "No");
        }

        //Contains element in Matrix
        static bool Search(int[,] mat, int colLenght,
            int rowLenght , int searchNumber)
        {

            int i = colLenght - 1, j = 0;
            while (i >= 0 && j < rowLenght)
            {
                if (mat[i, j] == searchNumber)
                    return true;
                if (mat[i, j] > searchNumber)
                    i--;
                else // if mat[i][j] < x
                    j++;
            }

            return false;
        }



    }
}
