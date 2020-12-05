using System;
using System.Diagnostics;

namespace Sorting_Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            var array = CreateArray();
            Stopwatch stopwatchBubbleSort = new Stopwatch();            
            BubbleSort bubbleSort = new BubbleSort();
            stopwatchBubbleSort.Start();
            var arrayBubbleSorted = bubbleSort.BubbleSortMethod(array);
            stopwatchBubbleSort.Stop();            
            Console.WriteLine($"Bubble Sort Method = {IsSorted(arrayBubbleSorted)} in {stopwatchBubbleSort.ElapsedTicks} ticks");

            var testQuickSortArray = CreateArray();
            QuickSort quickSort = new QuickSort();
            Stopwatch stopwatchQuickSort = new Stopwatch();
            stopwatchQuickSort.Start();
            var quckSorted = quickSort.QuickSortMethod(testQuickSortArray);
            stopwatchQuickSort.Stop();
            Console.WriteLine($"Quick Sort Method = {IsSorted(quckSorted)} in {stopwatchQuickSort.ElapsedTicks} ticks");
            
        }

        public static int[] CreateArray()
        {
            Random random = new Random();
            int[] array = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                array[i] = random.Next(1, 10000);
            }
            return array;
        }

        public static bool IsSorted(int[] array)
        {            
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] > array[i+1])
                    return false;                
            }
            return true;
        }
    }
}
