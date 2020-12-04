namespace Sorting_Methods
{
    public class QuickSort
    {       
        public static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }

        public static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        
        public static int[] QuickSortMethod(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSortMethod(array, minIndex, pivotIndex - 1);
            QuickSortMethod(array, pivotIndex + 1, maxIndex);

            return array;
        }

        public int[] QuickSortMethod(int[] array)
        {
            return QuickSortMethod(array, 0, array.Length - 1);
        }
    }
}
