/*************************************************************************
 *                           Weather Simulator
 *************************************************************************
 *This program will give you the most current weather (see note) for any 
 *of the cities it supports. It recieves its information from cutting edge 
 *meteorological stations (see note) located around the US.
 *
 * NOTE: Does not output accurate weather information.
 *       Does not connect to meteorological stations. 
 * 
 * Author(s): Casey
 *************************************************************************/

using System;

namespace WeatherSimulator
{
    class Program
    {
        public string[] city = new string[]{"Portland", "Eugene", "Springfield", "KlamathFalls", "Bend", "Ontario"};
        public string[] weather = new string[] { "Sunny", "Windy", "Raining", "Stormy", "Snowing", "Freezing", "Apocalyptic" };

        //for random num generation
        private Random rand = new Random();

        static void Main()
        {
            var p = new Program();
            int userNum = -1;
            string st = "";

            Console.WriteLine("Weather Simulator!\n");

            do
            {
                userNum = 0;
                Console.WriteLine(p.GetCityListString());

                do
                {
                    Console.WriteLine("Enter the number of the city you wish to see:");
                    st = Console.ReadLine();
                    int.TryParse(st, out userNum);
                    Console.WriteLine("");
                }
                while (userNum < 0 || userNum >= p.city.Length);

                Console.WriteLine(p.GenerateWeather(userNum));

                Console.WriteLine("\nPress enter to check another city. Press any key and then enter to quit.");
                st = Console.ReadLine();
                int.TryParse(st, out userNum);
            }
            while (userNum != 1);                                                                            //<--PROBLEM: This should be while (usernum == 0)

            Console.WriteLine("Goodbye");
            //Console.ReadKey();                                                                  <-- PROBLEM: This line shouldn't be commented out
        }

        private int randomNum(int min, int max)
        {
            return rand.Next(min, max);
        }

        private string GenerateWeather(int c)
        {
            string message = "In " + city[c] + ", it is ";

            message += weather[rand.Next(0, weather.Length-1)];                                     //PROBLEM: the second param for Next() should just be 'weather.Length'

            return message;
        }

        private string GetCityListString()
        {
            string list = "----------------------------------\n";
            int i = 0;
            foreach(string s in city)
            {
                list += i++ + ":  " + s + "\n";
            }
            list += "----------------------------------\n";
            return list;
        }
    }
}
