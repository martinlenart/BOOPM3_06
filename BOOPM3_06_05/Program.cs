using System;

namespace BOOPM3_06_05
{
    class Program
    {
        static class SelectionSort<T> where T:IEquatable<T>, IComparable<T>
        {
            public static void Sort(T[] array)
            {
                for (int unsortedStart = 0; unsortedStart < array.Length - 1; unsortedStart++)
                {
                    int minIndex = unsortedStart;
                    T minValue = array[unsortedStart];

                    //Iterate over the unsorted part
                    for (int i = unsortedStart + 1; i < array.Length; i++)
                    {
                        //Find the smalest element in the unsorted part
                        if (array[i].CompareTo(minValue) < 0)
                        {
                            minIndex = i;
                            minValue = array[i];
                        }
                    }

                    // Swap the smalest element with the 
                    (array[unsortedStart], array[minIndex]) = (array[minIndex], array[unsortedStart]);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] intArray = { 1, -5, 5, 16, 12, 3, 2, 8, 7, 3 };
            SelectionSort<int>.Sort(intArray);
            foreach (var item in intArray)
            {
                Console.Write($"{item,4}");
            }
            Console.WriteLine();

            string[] stringArray = "The quick brown fox catches the slow white rabbit".Split(' ');
            SelectionSort<string>.Sort(stringArray);
            foreach (var item in stringArray)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }

    //Excercises:
    //1. In BOOPM3_05_02, implement SelectionSort based on the Price and list the WineCellar in ascending price order 
}
