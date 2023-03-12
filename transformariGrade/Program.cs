using System;

namespace transformariGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alegeti transformarea pe care doriti sa o efectuati: \n1. Celsius -> Fahrenheit \n2. Fahrenheit -> Celsius \n3. Celsius -> Kelvin \n4. Kelvin -> Celsius");
            int optiune = int.Parse(Console.ReadLine());
            double gradeInitiale, rezultat;
            switch(optiune)
            {
                case 1:
                    Console.WriteLine("Introduceti gradele Celsius: ");
                    gradeInitiale = double.Parse(Console.ReadLine());
                    rezultat = (gradeInitiale * 1.8) + 32;
                    Console.WriteLine("{0} °C = {1} °F", gradeInitiale, rezultat);
                    break;
                case 2:
                    Console.WriteLine("Introduceti gradele Fahrenheit: ");
                    gradeInitiale = double.Parse(Console.ReadLine());
                    rezultat = (gradeInitiale - 32)/1.8;
                    Console.WriteLine("{0} °F = {1} °C", gradeInitiale, rezultat);
                    break;
                case 3:
                    Console.WriteLine("Introduceti gradele Celsius: ");
                    gradeInitiale = double.Parse(Console.ReadLine());
                    rezultat = gradeInitiale + 273.15;
                    Console.WriteLine("{0} °C = {1} °K", gradeInitiale, rezultat);
                    break;
                case 4:
                    Console.WriteLine("Introduceti gradele Kelvin: ");
                    gradeInitiale = double.Parse(Console.ReadLine());
                    rezultat = gradeInitiale - 273.15;
                    Console.WriteLine("{0} °K = {1} °C", gradeInitiale, rezultat);
                    break;
                default:
                    Console.WriteLine("Optiunea este incorecta");
                    break;
            }
        }
    }
}
