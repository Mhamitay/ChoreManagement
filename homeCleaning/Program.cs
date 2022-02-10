using homeCleaning.Models;
using homeCleaning.services;
using System;
using System.Collections.Generic;

namespace homeCleaning
{
    class Program
    {

        static void Main(string[] args)
        {
            var playerlst = new FromMemDataRepository().GetAllPlayers();
            var playersWithNumbers = GetRandomNumberForEachPlayer(playerlst);

            var shorelst = new FromMemDataRepository().GetAllShors();
            var shoresWithNumbers = GetRandomNumberForEachshore(shorelst);

            Console.Write("players are as follows" + Environment.NewLine);

            for (int i = 0; i < playersWithNumbers.Count; i++)
            {
                if (playersWithNumbers.TryGetValue(i, out Player strValue))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"Player number {i} is : {strValue._name}" + Environment.NewLine);
                }
            }


            Console.Write(Environment.NewLine + "player one please select on of the following numbers");
            Console.WriteLine(" " + Environment.NewLine);

            foreach (var item in shoresWithNumbers.Keys)
            {
                Console.WriteLine("- " + item + Environment.NewLine);

            }

            var aa = Console.ReadKey();

        }
        private static void checkEntered(string enter)
        {
            //if (enter.ToString() == ranA.ToString() || enter.ToString() == ranB.ToString() || enter.ToString() == ranC.ToString())
            //{
            //    if (tasks[0, int.Parse(enter)].ToString() == "clean the kitchen")
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;

            //    }
            //    else if (tasks[0, int.Parse(enter)].ToString() == "fridge and stove")
            //    {
            //        Console.ForegroundColor = ConsoleColor.Yellow;

            //    }
            //    else if (tasks[0, int.Parse(enter)].ToString() == "whipe the floors")
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //    }
            //    Console.WriteLine("You selected : " + tasks[0, int.Parse(enter)].ToString());
            //    Console.ForegroundColor = ConsoleColor.White;
            //    //Console.Read();
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.Write("you have selected the wrong numbers please try again");
            //    Console.WriteLine(" " + Environment.NewLine);
            //    Console.ForegroundColor = ConsoleColor.White;
            //    var enter1 = Console.ReadLine();
            //    checkEntered(enter1.ToString());
            //}
        }
        private static IDictionary<int,Player> GetRandomNumberForEachPlayer(List<Player> players)
        {
            var usedRandom = new List<int>();
            var playerList = new  Dictionary<int, Player>();

            foreach (var player in players)
            {
                lable:
                var numb = getRandomNumber();
               
                Player tt=null;
                if (!playerList.TryGetValue(numb,out tt))
                {
                    playerList.Add(numb, player);
                    usedRandom.Add(numb);
                }
                else
                {
                    goto lable;

                };
             
            }
            return playerList;
        }

        private static IDictionary<int, Shore> GetRandomNumberForEachshore(List<Shore> shores)
        {
            var usedRandom = new List<int>();
            var shoreList = new Dictionary<int, Shore>();

            foreach (var shore in shores)
            {
            lable:
                var numb = getRandomNumber10();

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

        private static int getRandomNumber()
        {
            Random random = new Random();
            int rInt = random.Next(0, 3); 
                                      
            return rInt;
        }

        private static int getRandomNumber10()
        {
            Random random = new Random();
            int rInt = random.Next(10, 100);

            return rInt;
        }

    }
}
