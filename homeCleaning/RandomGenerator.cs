using homeCleaning.Models;
using homeCleaning.services;
using System;
using System.Collections.Generic;

namespace homeCleaning
{
    public static class RandomGenerator
    {
        public static IDictionary<int, Player> GetRandomNumberForEachPlayer(List<Player> players)
        {
            var usedRandomNumbers = new List<int>();
            var playerList = new Dictionary<int, Player>();

            foreach (var player in players)
            {
                startLable:
                var randomNumber = getRandomNumber(0, players.Count+1);
                
                if (playerList.TryGetValue(randomNumber, out Player _player))
                {
                    goto startLable;
                }
                else
                {
                    playerList.Add(randomNumber, player);
                    usedRandomNumbers.Add(randomNumber);
                };

            }
            return playerList;
        }
        public  static IDictionary<int, Shore> GetRandomNumberForEachshore(List<Shore> shores)
        {
            var usedRandomNumbers = new List<int>();
            var shoreList = new Dictionary<int, Shore>();

            foreach (var shore in shores)
            {
                startLable:
                var number = getRandomNumber(10, 100);

                if (shoreList.TryGetValue(number, out Shore _shore))
                {
                    goto startLable;
                }
                else
                {
                    shoreList.Add(number, shore);
                    usedRandomNumbers.Add(number);
                };
            }
            return shoreList;
        }
        private static int getRandomNumber(int min, int max)
        {
            Random random = new Random();
            int number = random.Next(min, max);

            return number;
        }
        public static void AddRondomNumbersToShoresAndPlayer(List<Player> playerlst, List<Shore> shorelst, out IDictionary<int, Shore> shoresWithNumbers, out IDictionary<int, Player> playersWithNumbers)
        {
            shoresWithNumbers = GetRandomNumberForEachshore(shorelst);
            playersWithNumbers = GetRandomNumberForEachPlayer(playerlst);
        }
    }
}