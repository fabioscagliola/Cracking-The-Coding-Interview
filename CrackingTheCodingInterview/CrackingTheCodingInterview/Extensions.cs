using System.Collections.Generic;

namespace com.fabioscagliola.CrackingTheCodingInterview
{
    static class Extensions
    {
        /// <summary>
        /// Generates all possible permutations of a list of objects using Heap's algorithm 
        /// </summary>
        public static List<List<T>> GeneratePermutations<T>(this List<T> list)
        {
            List<List<T>> permutations = new();
            Heap(list, list.Count, permutations);
            return permutations; ;
        }

        /// <summary>
        /// Swaps two items in a list 
        /// </summary>
        public static void Swap<T>(this List<T> list, int index1, int index2)
        {
            T temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }

        static void Heap<T>(List<T> list, int length, List<List<T>> result)
        {
            if (length == 1)
            {
                result.Add(new List<T>(list));
            }
            else
            {
                Heap(list, length - 1, result);

                for (int i = 0; i < length - 1; i++)
                {
                    if (length % 2 == 0)
                    {
                        list.Swap(i, length - 1);
                    }
                    else
                    {
                        list.Swap(0, length - 1);
                    }

                    Heap(list, length - 1, result);
                }
            }
        }

    }
}

