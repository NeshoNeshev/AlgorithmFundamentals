using System;
using System.Collections.Generic;

namespace Permutations
{
    class Program
    {
        private static string[] elements;

        private static string[] permiutations;

        private static bool[] used;

        private static HashSet<string> permiutationsHash;

        static void Main(string[] args)
        {
            //elements = new[] { "A", "B", "C" };
            //permiutations = new string[elements.Length];
            //used = new bool[elements.Length];

            //Permute(0);
            elements = new[] {"A", "B", "B"};
            permiutationsHash = new HashSet<string>();

            OptimizePermute(0);
            
        }

        private static void Permute(int permutationsIndex)
        {
            if (permutationsIndex >= elements.Length)
            {
                Console.WriteLine(string.Join(" ", permiutations));
                return;
            }

            for (int elementsIdx = 0; elementsIdx < elements.Length; elementsIdx++)
            {
                if (!used[elementsIdx])
                {
                    used[elementsIdx] = true;
                    permiutations[permutationsIndex] = elements[elementsIdx];
                    Permute(permutationsIndex + 1);
                    used[elementsIdx] = false;
                }
            }
        }

        // Permutations with Repetition Count
        private static void OptimizePermute(int permutationsIndex)
        {
            if (permutationsIndex >= elements.Length)
            {
                Console.WriteLine(string.Join(" ", elements));
                return;
            }

            OptimizePermute(permutationsIndex + 1);

            var swapped = new HashSet<string> { elements[permutationsIndex] };

            for (int i = permutationsIndex + 1; i < elements.Length; i++)
            {
                if (!swapped.Contains(elements[i]))
                {
                    Swap(permutationsIndex, i);
                    OptimizePermute(permutationsIndex + 1);
                    Swap(permutationsIndex, i);
                    swapped.Add(elements[i]);
                }
            }
        }

        private static void Swap(int first, int second)
        {
            var temp = elements[first];
            elements[first] = elements[second];
            elements[second] = temp;
        }
    }
}
