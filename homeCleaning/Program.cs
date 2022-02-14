using homeCleaning.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace homeCleaning
{
    partial class Program
    {

        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();

            var playersWithNumbers = gameManager.GetRandomNumberForEachPlayer();
            var shoresWithNumbers = gameManager.GetRandomNumberForEachshore();

            AGAIN:
            Console.Clear();
            Console.Write("players are as follows" + Environment.NewLine);

            for (int i = 0; i < playersWithNumbers.Count; i++)
            {
                if (playersWithNumbers.TryGetValue(i,out string val))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"Player number {i} is : {val}" + Environment.NewLine);
                }
            }

            foreach (var item in shoresWithNumbers.Keys)
            {
                Console.WriteLine("- " + item);
            }

            QUESTION:

            Console.Write(Environment.NewLine + "Please select numbers");
            Console.WriteLine(" " + Environment.NewLine);

            string selectedNumber = Console.ReadLine();

            if (selectedNumber == "q" || selectedNumber == "Q")
            {

            }
            else if (selectedNumber == "again" || selectedNumber == "Again" || selectedNumber == "AGAIN")
            {
                Console.Clear();
                goto AGAIN;
            }
            else
            {
                checkEntered(selectedNumber, shoresWithNumbers);
                goto QUESTION;
            }
        }

        private static void checkEntered(string selectedNumber, IDictionary<int, Shore> shoresWithNumbers)
        {
            int _selectedNumber = int.Parse(selectedNumber);
            if (shoresWithNumbers.TryGetValue(_selectedNumber, out Shore shore))
            {
                if (shore.name == "kitchen" || shore.name == "Gurage")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine($" You have selected --- {shore.name}");
                Console.ForegroundColor = ConsoleColor.White;
            };
        }
    }
}
