

using ChoreManagement.core.lib.Models;

namespace ChoreManagement.core.lib.Services
{
    public class ChoreManager
    {
        public static void GetInitialData(out List<Player> playerlst, out List<Chore> shorelst)
        {
            DataProvider.InitiateData(out playerlst, out shorelst);
        }
        public static void AddRondomNumbersToChoresAndPlayer(List<Player> playerlst, List<Chore> shorelst, out IDictionary<int, Chore> shoresWithNumbers, out IDictionary<int, Player> playersWithNumbers)
        {
            GetRondomNumbersToList(playerlst, shorelst, out shoresWithNumbers, out playersWithNumbers);
        }

        public static void GetRondomNumbersToList(List<Player> playerlst, List<Chore> shorelst, out IDictionary<int, Chore> shoresWithNumbers, out IDictionary<int, Player> playersWithNumbers)
        {
            RandomNumbersGenerator<Player> _playerRandom = new RandomNumbersGenerator<Player>(playerlst);
            playersWithNumbers = _playerRandom.GetRandomNumberForEachObject();

            RandomNumbersGenerator<Chore> _shoreRandom = new RandomNumbersGenerator<Chore>(shorelst);
            shoresWithNumbers = _shoreRandom.GetRandomNumberForEachObject();
        }
        public static int ProcessEntry(string numberEntred, IDictionary<int, Chore> shoresWithNumbers)
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

            if (shoresWithNumbers.TryGetValue(int.Parse(numberEntred), out Chore _shore))
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