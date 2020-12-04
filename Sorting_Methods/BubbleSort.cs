
namespace Sorting_Methods
{
    class BubbleSort
    {
        public int[] BubbleSortMethod(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }
            return array;
        }

        public static void Swap(ref int i, ref int j)
        {
            var temp = i;
            i = j;
            j = temp;
        }
    }
}
