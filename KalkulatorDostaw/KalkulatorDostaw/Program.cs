using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalkulator
{
    class Program
    {

        static int pogoda = 0;
        static int pojazd = 0;
        static double dystans = 0;
        static int czas = 0;

        static void Main(string[] args)
        {

            Console.WriteLine("Podaj aktualną pogodę: 1-słońce, 2-deszcz, 3-śnieg");
            Int32.TryParse(Console.ReadLine(), out pogoda);
            do
            {
                Console.WriteLine("Podaj wybrany pojazd: 1-pieszo, 2-rower, 3-auto");
                Int32.TryParse(Console.ReadLine(), out pojazd);
            }
            while (pojazd < 1 || pojazd > 3);


            if (pojazd < 1 || pojazd > 3) Console.WriteLine("pojazd spoza zakresu");
            Console.WriteLine("Podaj dystans (0-10km)");
            Double.TryParse(Console.ReadLine(), out dystans);

            if (pogoda == 1)
            {
                if (dystans < 0.5)
                {
                    Console.WriteLine("Dowóz będzie pieszo");
                }
                else if (dystans >= 0.5 && dystans < 5)
                {
                    Console.WriteLine("Dowóz będzie rowerem");
                }
                else
                {
                    Console.WriteLine("Dowóz będzie samochodem");
                }
            }
            else if (pogoda == 2)
            {
                if (dystans <= 1.9)
                {
                    Console.WriteLine("Dowóz będzie rowerem");
                }
                else
                {
                    Console.WriteLine("Dowóz będzie samochodem");
                }

            }
            else if (pogoda == 3)
            {
                Console.WriteLine("Dowóz będzie samochodem");
            }
            else
            {
                Console.WriteLine("Podałeś błędnie pogodę");
            }

            double mnoznik = 1;

            if (pogoda == 2) mnoznik = 1.5;
            else if (pogoda == 3) mnoznik = 2.2;


            if (pojazd == 3)
            {
                czas = (int)(dystans / 50 * 60 * mnoznik);
                Console.WriteLine($"szacowany czas to {czas} minut");
            }
            else if (pojazd == 2)
            {
                czas = (int)(dystans / 15 * 60 * mnoznik);
                Console.WriteLine($"szacowany czas to {czas} minut");
            }
            else if (pojazd == 1)
            {
                czas = (int)(dystans / 5 * 60 * mnoznik);
                Console.WriteLine($"szacowany czas to {czas} minut");
            }
            else
            {
                Console.WriteLine($"Podałeś błędny pojazd");
            }


            Console.ReadLine();

        }
    }
}
