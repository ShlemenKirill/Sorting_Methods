
using System;

namespace Sorting_Methods
{
    class BogoSort
    {
        public static bool IsSorted(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] > a[i + 1])
                    return false;
            }
            return true;
        }

        public static int[] Permutation(int[] a)
        {
            Random random = new Random();
            var length = a.Length;
            while (length > 1)
            {
                length--;
                var i = random.Next(length + 1);
                var temp = a[i];
                a[i] = a[length];
                a[length] = temp;
            }
            return a;
        }

        public int[] BogoSortMethod(int[] a)
        {
            while (!IsSorted(a))
            {
                a = Permutation(a);
            }
            return a;
        }
    }
}
