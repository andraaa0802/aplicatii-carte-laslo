using System;

namespace NumarFibonacci
{
    class Program
    {
        static bool PatratPerfect(int n)
        {
            int radical = (int)Math.Sqrt(n);
            if (radical * radical == n)
                return true;
            return false;
        }
        static bool NumarFibonacci(int n)
        {
            return (PatratPerfect(5 * n * n + 4) || PatratPerfect (5 * n * n - 4));
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Cate elemente are vectorul?");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Introduceti pe o singura linie elementele vectorului, despartite prin cate un spatiu: ");
            string[] buffer = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(buffer[i]);
            for (int i = 0; i < n; i++)
                if (NumarFibonacci(v[i]) == true)
                    Console.WriteLine(v[i] + " ");
        }
    }
}
