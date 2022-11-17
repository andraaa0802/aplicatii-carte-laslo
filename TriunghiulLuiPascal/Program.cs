using System;

namespace TriunghiulLuiPascal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[,] M = new int[n, n];

            M[0, 0] = 1;
            for (int i = 1; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (i == j || j == 0)
                        M[i, j] = 1;
                    else
                        M[i, j] = M[i - 1, j - 1] + M[i - 1, j];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    if (M[i, j] != 0)
                        Console.Write(M[i, j] + " ");
                Console.WriteLine();
            }

        }
    }
}
