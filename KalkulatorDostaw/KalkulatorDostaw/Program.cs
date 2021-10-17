using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading;

namespace KalkulatorDostaw
{
    class Program
    {

        static int pogoda = 0;
        static int pojazd = 0;
        static double dystans = 0;
        static int czas = 0;

        static void Main(string[] args)
        {
            Console.WriteLine(Properties.Language.SetActualWeather);
            Int32.TryParse(Console.ReadLine(), out pogoda);

            do
            {
                Console.WriteLine(Properties.Language.SetVehicle);
                Int32.TryParse(Console.ReadLine(), out pojazd);
            }
            while (pojazd < 1 || pojazd > 3);

            if (pojazd < 1 || pojazd > 3)
            {
                Console.WriteLine(Properties.Language.WrongVehicle);
            }

            Console.WriteLine(Properties.Language.SetDistance);
            Double.TryParse(Console.ReadLine(), out dystans);

            if (pogoda == 1)
            {
                if (dystans < 0.5)
                {
                    Console.WriteLine(Properties.Language.DeliveryOnFoot);
                }
                else if (dystans >= 0.5 && dystans < 5)
                {
                    Console.WriteLine(Properties.Language.DeliveryByBike);
                }
                else
                {
                    Console.WriteLine(Properties.Language.DeliveryByCar);
                }
            }
            else if (pogoda == 2)
            {
                if (dystans <= 1.9)
                {
                    Console.WriteLine(Properties.Language.DeliveryByBike);
                }
                else
                {
                    Console.WriteLine(Properties.Language.DeliveryByCar);
                }

            }
            else if (pogoda == 3)
            {
                Console.WriteLine(Properties.Language.DeliveryByCar);
            }
            else
            {
                Console.WriteLine(Properties.Language.WrongWeather);
            }

            double mnoznik = 1;

            if (pogoda == 2) mnoznik = 1.5;
            else if (pogoda == 3) mnoznik = 2.2;


            if (pojazd == 3)
            {
                czas = (int)(dystans / 50 * 60 * mnoznik);
                Console.WriteLine(Properties.Language.EstimatedTime);
            }
            else if (pojazd == 2)
            {
                czas = (int)(dystans / 15 * 60 * mnoznik);
                Console.WriteLine(Properties.Language.EstimatedTime);
            }
            else if (pojazd == 1)
            {
                czas = (int)(dystans / 5 * 60 * mnoznik);
                Console.WriteLine(Properties.Language.EstimatedTime);
            }
            else
            {
                Console.WriteLine(Properties.Language.WrongVehicle);
            }


            Console.ReadLine();

        }
    }
}
