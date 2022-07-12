using homeCleaning.Models;
using homeCleaning.services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace homeCleaning
{
    partial class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, Shore> shoresWithNumbers;
            IDictionary<int, Player> playersWithNumbers;
            List<Player> playerlst;
            List<Shore> shorelst;

            DiceManager.GetInitialData(out playerlst, out shorelst);
            DiceManager.AddRondomNumbersToShoresAndPlayer(playerlst, shorelst, out shoresWithNumbers, out playersWithNumbers);
            
            DisplayPlayers(playersWithNumbers);
            DisplaySelectNumber(shoresWithNumbers);
        }
        private static void DisplayPlayers(IDictionary<int,Player> playersWithNumbers)
        {
            Console.Write("players are as follows" + Environment.NewLine);
            for (int i = 0; i <= playersWithNumbers.Keys.Count+1; i++)
            {
                if (playersWithNumbers.TryGetValue(i,out Player val))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"Player number {i} is : {val._name}" + Environment.NewLine);
                }
            }
        }
        private static void DisplaySelectNumber(IDictionary<int, Shore> shoresWithNumbers)
        {
            Console.Write(Environment.NewLine + "Please select on of the following numbers");
            Console.WriteLine(" " + Environment.NewLine);

            foreach (var item in shoresWithNumbers.Keys)
            {
                Console.WriteLine("- " + item + Environment.NewLine);
            }
            var numberEntred = Console.ReadLine();
            switch (DiceManager.ProcessEntry(numberEntred, shoresWithNumbers))
            {
                case 0:
                    Console.WriteLine("You selected to quit the application.. Good bye!");
                    Console.WriteLine("Please press any key to close");
                    Console.ReadKey();
                    return;
                    break;
                case 1:
                    Console.WriteLine("---------------------------------------------- ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("please enter a valid number, please try again..");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("---------------------------------------------- " + Environment.NewLine);
                    DisplaySelectNumber(shoresWithNumbers);
                    break;
                default:
                    DisplaySelectNumber(shoresWithNumbers);
                    break;
            }
            
        }
     }
}
