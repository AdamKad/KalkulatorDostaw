using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading;

namespace DeliveryCalculator
{
    class Program
    {
        static int weather = 0;
        static int vehicle = 0;
        static double distance = 0;
        static int time = 0;

        static void Main(string[] args)
        {
            Console.WriteLine(Properties.Language.SetActualWeather);
            Int32.TryParse(Console.ReadLine(), out weather);

            do
            {
                Console.WriteLine(Properties.Language.SetVehicle);
                Int32.TryParse(Console.ReadLine(), out vehicle);
            }
            while (vehicle < 1 || vehicle > 3);

            if (vehicle < 1 || vehicle > 3)
            {
                Console.WriteLine(Properties.Language.WrongVehicle);
            }

            Console.WriteLine(Properties.Language.SetDistance);
            Double.TryParse(Console.ReadLine(), out distance);

            if (weather == 1)
            {
                if (distance < 0.5)
                {
                    Console.WriteLine(Properties.Language.DeliveryOnFoot);
                }
                else if (distance >= 0.5 && distance < 5)
                {
                    Console.WriteLine(Properties.Language.DeliveryByBike);
                }
                else
                {
                    Console.WriteLine(Properties.Language.DeliveryByCar);
                }
            }
            else if (weather == 2)
            {
                if (distance <= 1.9)
                {
                    Console.WriteLine(Properties.Language.DeliveryByBike);
                }
                else
                {
                    Console.WriteLine(Properties.Language.DeliveryByCar);
                }

            }
            else if (weather == 3)
            {
                Console.WriteLine(Properties.Language.DeliveryByCar);
            }
            else
            {
                Console.WriteLine(Properties.Language.WrongWeather);
            }

            double mnoznik = 1;

            if (weather == 2) mnoznik = 1.5;
            else if (weather == 3) mnoznik = 2.2;


            if (vehicle == 3)
            {
                time = (int)(distance / 50 * 60 * mnoznik);
                Console.WriteLine(Properties.Language.EstimatedTime);
            }
            else if (vehicle == 2)
            {
                time = (int)(distance / 15 * 60 * mnoznik);
                Console.WriteLine(Properties.Language.EstimatedTime);
            }
            else if (vehicle == 1)
            {
                time = (int)(distance / 5 * 60 * mnoznik);
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
