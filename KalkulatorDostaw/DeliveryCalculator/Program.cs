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
        static double distance = -1.0;
        static int time = 0;

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine(Properties.Language.SetActualWeather);
                Int32.TryParse(Console.ReadLine(), out weather);
            }
            while (weather < 1 || weather > 3);

            do
            {
                Console.WriteLine(Properties.Language.SetVehicle);
                Int32.TryParse(Console.ReadLine(), out vehicle);
            }
            while (vehicle < 1 || vehicle > 3);

            do
            {
                Console.WriteLine(Properties.Language.SetDistance);
                distance = GetDouble(Console.ReadLine());
            }
            while (distance < 0 || distance > 10);

            switch (weather)
            {
                case 1:
                    if (distance < 0.5)
                        Console.WriteLine(Properties.Language.DeliveryOnFoot);
                    else if (distance >= 0.5 && distance < 5)
                        Console.WriteLine(Properties.Language.DeliveryByBike);
                    else
                        Console.WriteLine(Properties.Language.DeliveryByCar);
                    break;
                case 2:
                    if (distance <= 1.9)
                        Console.WriteLine(Properties.Language.DeliveryByBike);
                    else
                        Console.WriteLine(Properties.Language.DeliveryByCar);
                    break;
                case 3:
                    Console.WriteLine(Properties.Language.DeliveryByCar);
                    break;
            }

            double multiplier = 1;

            if (weather == 2) multiplier = 1.5;
            else if (weather == 3) multiplier = 2.2;

            switch (vehicle)
            {
                case 1:
                    time = (int)(distance / 5 * 60 * multiplier);
                    break;
                case 2:
                    time = (int)(distance / 15 * 60 * multiplier);
                    break;
                case 3:
                    time = (int)(distance / 50 * 60 * multiplier);
                    break;
            }

            Console.WriteLine(Properties.Language.EstimatedTime.Replace("{time}", time.ToString()));
            Console.ReadLine();
        }

        private static double GetDouble(string value)
        {
            double result;

            //Current culture
            if (!double.TryParse(value, NumberStyles.Any, CultureInfo.CurrentCulture, out result) &&
                //en-US culture
                !double.TryParse(value, NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out result) &&
                //neutral culture
                !double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out result))
            {
                result = -1.0;
            }

            return result;
        }
    }
}
