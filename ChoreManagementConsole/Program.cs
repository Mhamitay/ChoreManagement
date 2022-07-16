﻿
using ChoreManagement.core.lib.Models;
using ChoreManagement.core.lib.Services;

IDictionary<int, Chore> shoresWithNumbers;
IDictionary<int, Player> playersWithNumbers;
List<Player> playerlst;
List<Chore> shorelst;

DiceManager.GetInitialData(out playerlst, out shorelst);
DiceManager.AddRondomNumbersToShoresAndPlayer(playerlst, shorelst, out shoresWithNumbers, out playersWithNumbers);

DisplayPlayers(playersWithNumbers);
DisplaySelectNumber(shoresWithNumbers);

 static void DisplayPlayers(IDictionary<int, Player> playersWithNumbers)
{
    Console.Write("players are as follows" + Environment.NewLine);
    for (int i = 0; i <= playersWithNumbers.Keys.Count + 1; i++)
    {
        if (playersWithNumbers.TryGetValue(i, out Player val))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Player number {i} is : {val._name}" + Environment.NewLine);
        }
    }
}
 static void DisplaySelectNumber(IDictionary<int, Chore> shoresWithNumbers)
{
    Console.Write(Environment.NewLine + "Please select on of the following numbers");
    Console.WriteLine();

    foreach (int number in shoresWithNumbers.Keys)
    {
        Console.WriteLine("- " + number);
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