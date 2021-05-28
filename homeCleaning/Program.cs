using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeCleaning
{
    class Program
    {
        public static int ran1;
        public static int ran2;
        public static int ran3;

        public static int r1;
        public static int r2;
        public static int r3;

        public static int intCount = 0;
        public static int ranA;
        public static int ranB;
        public static int ranC;

        static string[,] tasks = new string[1, 100];
        static string[] t = new string[3];
        static void Main(string[] args)
        {
            getThePlayingOrder();
            TillRandomValues();
            string enter = null;
            for (int i = 0; i < 3; i++)
            {
                if (intCount == 0)
                {

                    Console.Write("player one please select on of the following numbers");
                    Console.WriteLine(" " + Environment.NewLine);
                    Console.WriteLine(" " + ranA.ToString());
                    Console.WriteLine(" " + ranB.ToString());
                    Console.WriteLine(" " + ranC.ToString());
                    Console.WriteLine(" " + Environment.NewLine);
                    enter = Console.ReadLine();
                    intCount++;

                }
                else
                {
                    Console.Write("player tow please select on of the non selected numbers");
                    Console.WriteLine(" " + Environment.NewLine);
                    enter = Console.ReadLine();
                    // checkEntered(enter);
                }
                checkEntered(enter);

            }
            Console.Write("Please press any key to exit");
            Console.Read();

        }

        private static void checkEntered(string enter)
        {
            if (enter.ToString() == ranA.ToString() || enter.ToString() == ranB.ToString() || enter.ToString() == ranC.ToString())
            {
                if (tasks[0, int.Parse(enter)].ToString() == "clean the kitchen")
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                }
                else if (tasks[0, int.Parse(enter)].ToString() == "fridge and stove")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;

                }
                else if (tasks[0, int.Parse(enter)].ToString() == "whipe the floors")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine("You selected : " + tasks[0, int.Parse(enter)].ToString());
                Console.ForegroundColor = ConsoleColor.White;
                //Console.Read();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("you have selected the wrong numbers please try again");
                Console.WriteLine(" " + Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.White;
                var enter1 = Console.ReadLine();
                checkEntered(enter1.ToString());
            }
        }

        private static void TillRandomValues()
        {

            ranA = getRandomA();

            do
            {
                ranB = getRandomA();
            } while (ranA == ranB);

            do
            {
                ranC = getRandomA();
            } while (ranC == ranB || ranC == ranA);


            r1 = getRandomNumber();

            do
            {
                r2 = getRandomNumber();
            } while (r2 == r1);


            do
            {
                r3 = getRandomNumber();
            } while (r3 == r1 || r3 == r2);


            t[r1] = "clean the kitchen";
            t[r2] = "whipe the floors";
            t[r3] = "fridge and stove";


            tasks[0, ranA] = t[0].ToString();
            tasks[0, ranB] = t[1].ToString();
            tasks[0, ranC] = t[2].ToString();






        }

        private static void getThePlayingOrder()
        {

            Dictionary<int, string> players = new Dictionary<int, string>();
            players[0] = "ayah";
            players[1] = "Hajir";
            players[2] = "solafah";

            int ra1;
            int ra2;
            int ra3;

            ra1 = getRandomNumber();

            do
            {
                ra2 = getRandomNumber();
            } while (ra2 == ra1);


            do
            {
                ra3 = getRandomNumber();
            } while (ra3 == ra1 || ra3 == ra2);



            Console.WriteLine("1 " + players[ra1].ToString());
            Console.WriteLine("2 " + players[ra2].ToString());
            Console.WriteLine("3 " + players[ra3].ToString());
            Console.WriteLine("---------------------------------");



            Console.WriteLine(" ");
            //Console.Read();

            //Random r = new Random();
            //int rInt = r.Next(0, 100); //for ints
            //int range = 100;
            //double rDouble = r.NextDouble() * range; //for doubles
        }

        private static int getRandomNumber()
        {
            Random r = new Random();
            int rInt = r.Next(0, 3); //for ints
                                     // int range = 100;
            return rInt;
        }
        private static int getRandomA()
        {
            Random r = new Random();
            int rInt = r.Next(1, 100); //for ints
                                       // int range = 100;
            return rInt;
        }
    }
}
