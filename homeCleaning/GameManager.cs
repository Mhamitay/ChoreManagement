using HomeCleaningLib.Models;
using HomeCleaningLib.services;
using System;
using System.Collections.Generic;

namespace HomeCleaning
{

        public class GameManager
        {
            public IDictionary<int, string> GetRandomNumberForEachPlayer()
            {
                var playerlst = new FromMemDataRepository().GetAllPlayers();

                var usedRandom = new List<int>();
                var playerList = new Dictionary<int, string>();

                int min = 0;
                int max = playerlst.Count;

                foreach (var player in playerlst)
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
            public IDictionary<int, Shore> GetRandomNumberForEachshore()
            {
                var shorelst = new FromMemDataRepository().GetAllShors();
                var usedRandom = new List<int>();
                var shoreList = new Dictionary<int, Shore>();
                int min = 10;
                int max = shorelst.Count * 10;

                foreach (var shore in shorelst)
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
