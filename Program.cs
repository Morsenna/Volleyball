using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfYear = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekendsInHomeTown = int.Parse(Console.ReadLine());
            int weekendsInSofia = 48 - weekendsInHomeTown;
            double SaturdaysInSofia = weekendsInSofia * (3.0 / 4);
            double playInHomeTown = weekendsInHomeTown;
            double playInHolidays = holidays * (2.0 / 3);
            double allGames = SaturdaysInSofia + playInHolidays + playInHomeTown;
            double result = 0.0;
            double totalResult = 0.0;
            if (typeOfYear == "leap")
            {
               result = (allGames / 100.00) * 15;
               totalResult = allGames + result;
            }
            else if (typeOfYear == "normal")
            {
               totalResult = allGames;
            }
            Console.WriteLine(Math.Truncate(totalResult));
        }
    }

}
