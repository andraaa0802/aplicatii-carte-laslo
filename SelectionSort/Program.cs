using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = { 15, 11, 24, 102, 17, 45, 87, 8, 20 };
            SelectionSort(v);
            foreach(int i in v)
                Console.Write(i+ " ");
        }

        static void SelectionSort(int[] v)
        {
            int n = v.Length;
            for(int i=0;i<n-1;i++)
            {
                int poz = i;
                for (int j = i + 1; j < n; j++)
                    if (v[j] < v[poz])
                        poz = j;
                (v[poz], v[i]) = (v[i], v[poz]);
            }
        }
    }
}
