using homeCleaning.Models;
using homeCleaning.services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace homeCleaning
{
    class Program
    {

        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();
            var playerlst = new FromMemDataRepository().GetAllPlayers();
            var playersWithNumbers = gameManager.GetRandomNumberForEachPlayer(playerlst);

            var shorelst = new FromMemDataRepository().GetAllShors();
            var shoresWithNumbers = gameManager.GetRandomNumberForEachshore(shorelst);

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

        private class GameManager
        {
            public IDictionary<int, string> GetRandomNumberForEachPlayer(List<Player> players)
            {
                var usedRandom = new List<int>();
                var playerList = new Dictionary<int, string>();

                int min = 0;
                int max = players.Count;

                foreach (var player in players)
                {
                lable:
                    var numb = getRandomNumber(min, max);

                    if (!playerList.TryGetValue(numb, out string _player))
                    {
                        playerList.Add(numb, player._name);
                        usedRandom.Add(numb);
                    }
                    else
                    {
                        goto lable;
                    };

                }
                return playerList;
            }
            public IDictionary<int, Shore> GetRandomNumberForEachshore(List<Shore> shores)
            {
                var usedRandom = new List<int>();
                var shoreList = new Dictionary<int, Shore>();
                int min = 10;
                int max = shores.Count * 10;

                foreach (var shore in shores)
                {
                lable:
                    var numb = getRandomNumber(min, max);

                    Shore _shore = null;
                    if (!shoreList.TryGetValue(numb, out _shore))
                    {
                        shoreList.Add(numb, shore);
                        usedRandom.Add(numb);
                    }
                    else
                    {
                        goto lable;

                    };
                }
                return shoreList;
            }
            public int getRandomNumber(int min, int max)
            {
                Random random = new Random();
                int rInt = random.Next(min, max + 1);

                return rInt;
            }
        }
    }
}
