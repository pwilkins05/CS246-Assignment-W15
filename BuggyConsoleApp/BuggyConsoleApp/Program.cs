using System;

namespace BuggyConsoleApp
{
    class Program
    {
        // TODO: Change it so the output of the function is brewery, beer
        // TODO: fix one syntax error
        static void Main(string[] args)
        {
            Console.WriteLine("This app should print Brewery, Beer:\n");
            PrintBeers();
            Console.ReadLine();
        }

        static void PrintBeers()
        {
            string[] breweries = new string[] { "Ninkasi", "Hop Valley", "Boneyard", "Laurelwood" };
            string[] beers = new string[] { "Total Domination IPA", "Alphadelic IPA", "RPM IPA", "Workhorse IPA" };

            for (int i = 0; i < beers.Length; i++)
            {
                Console.WriteLine(beers[i] + ", " + breweries[i] + "\n")
            }
        }
    }
}
