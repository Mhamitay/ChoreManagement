using homeCleaning.Models;
using homeCleaning.services;
using System;
using System.Collections.Generic;

namespace homeCleaning
{
    public class DiceManager
    {
        public static void GetInitialData(out List<Player> playerlst, out List<Shore> shorelst)
        {
            DataProvider.InitiateData(out playerlst, out shorelst);
        }
        public static void AddRondomNumbersToShoresAndPlayer(List<Player> playerlst, List<Shore> shorelst, out IDictionary<int, Shore> shoresWithNumbers, out IDictionary<int, Player> playersWithNumbers)
        {
            RandomGenerator.AddRondomNumbersToShoresAndPlayer(playerlst, shorelst,out shoresWithNumbers, out playersWithNumbers);
        }
        public static int ProcessEntry(string numberEntred, IDictionary<int, Shore> shoresWithNumbers)
        {
            if (numberEntred == "q" || numberEntred == "Q")
            {
                 return 0;
            }

            var result = int.TryParse(numberEntred, out int value);

            if (!result)
            {
                return 1;
            }

            if (shoresWithNumbers.TryGetValue(int.Parse(numberEntred), out Shore _shore))
            {
                if (_shore.name == "kitchen")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("------------------------------");
                    Console.WriteLine(_shore.name);
                    Console.WriteLine("------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("------------------------------");
                    Console.WriteLine(_shore.name);
                    Console.WriteLine("------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }
            else
            {
                //Console.WriteLine("please enter a valid number, please try again..");
                return 1;
            };
            return 3;
        }

    }
}