using System;

namespace ArabeInRomane
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul: ");
            int numar = int.Parse(Console.ReadLine());

            string rezultat = "";
            string[] numereRomane = { "(M)", "(C)(M)", "(D)", "(C)(D)", "(C)", "(X)(C)", "(L)", "(X)(L)", "(X)", "C(X)", "(V)", "M(V)", "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] numereArabe = { 1000000, 900000, 500000, 400000, 100000, 90000, 50000, 40000, 10000, 9000, 5000, 4000, 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            int i = 0;
            while (numar != 0)
            {
                if (numar >= numereArabe[i])
                {
                    numar -= numereArabe[i];
                    rezultat += numereRomane[i];
                }
                else
                    i++;
            }
            Console.WriteLine(rezultat);
        }
    }
}
