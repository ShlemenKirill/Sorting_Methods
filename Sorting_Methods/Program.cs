using System;

namespace Sorting_Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            var array = CreateArray();           
            
            BubbleSort bubbleSort = new BubbleSort();
            var arrayBubbleSorted = bubbleSort.BubbleSortMethod(array);            
            Console.WriteLine($"Bubble Sort Method = {IsSorted(arrayBubbleSorted)}"); 
            
            QuickSort quickSort = new QuickSort();
            var quckSorted = quickSort.QuickSortMethod(array);            
            Console.WriteLine($"Bubble Sort Method = {IsSorted(quckSorted)}");

            BogoSort bogoSort = new BogoSort();
            var bogoSorted = bogoSort.BogoSortMethod(array);            
            Console.WriteLine($"BogoSort Method = {IsSorted(bogoSorted)}");
        }

        public static int[] CreateArray()
        {
            Random random = new Random();
            int[] array = new int[100];
            for (int i = 0; i < 100; i++)
            {
                array[i] = random.Next(1, 1000);
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
