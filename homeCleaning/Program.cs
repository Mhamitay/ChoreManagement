using homeCleaning.services;
using System;
using System.Collections.Generic;

namespace homeCleaning
{
    class Program
    {

        static void Main(string[] args)
        {
            var data = DataRepository.GetAllPlayers();

            var dd = GetRandomNumberForEachPlayer(data);
            string enter = null;
            for (int i = 0; i < 3; i++)
            {
            //    if (intCount == 0)
            //    {

            //        Console.Write("player one please select on of the following numbers");
            //        Console.WriteLine(" " + Environment.NewLine);
            //        Console.WriteLine(" " + ranA.ToString());
            //        Console.WriteLine(" " + ranB.ToString());
            //        Console.WriteLine(" " + ranC.ToString());
            //        Console.WriteLine(" " + Environment.NewLine);
            //        enter = Console.ReadLine();
            //        intCount++;

            //    }
            //    else
            //    {
            //        Console.Write("player tow please select on of the non selected numbers");
            //        Console.WriteLine(" " + Environment.NewLine);
            //        enter = Console.ReadLine();
            //        // checkEntered(enter);
            //    }
            //    checkEntered(enter);

            }
            //Console.Write("Please press any key to exit");
            //Console.Read();

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
            var x = new  Dictionary<int, Player>();

            foreach (var player in players)
            {
                lable:
                var numb = getRandomNumber();
               
                Player tt=null;
                if (!x.TryGetValue(numb,out tt))
                {
                    x.Add(numb, player);
                    usedRandom.Add(numb);
                }
                else
                {
                    goto lable;

                };
             
            }
            return null;
        }




        private static int getRandomNumber()
        {
            Random random = new Random();
            int rInt = random.Next(0, 3); 
                                      
            return rInt;
        }
    
    }
}
