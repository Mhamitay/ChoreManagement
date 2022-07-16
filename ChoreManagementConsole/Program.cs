
using ChoreManagement.core.lib.Models;
using ChoreManagement.core.lib.Services;

ChoreEntity choreEntity = new();

DiceManager.GetInitialData(out choreEntity.playerlst, out choreEntity.shorelst);
DiceManager.AddRondomNumbersToShoresAndPlayer(choreEntity.playerlst, choreEntity.shorelst, out choreEntity.shoresWithNumbers, out choreEntity.playersWithNumbers);

DisplayPlayers(choreEntity.playersWithNumbers);
DisplaySelectNumber(choreEntity.shoresWithNumbers);

 static void DisplayPlayers(IDictionary<int, Player> playersWithNumbers)
{
    Console.Write("players are as follows" + Environment.NewLine);
    for (int i = 0; i <= playersWithNumbers.Keys.Count + 1; i++)
    {
        if (playersWithNumbers.TryGetValue(i, out Player player))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Player number {i} is : {player._name}" + Environment.NewLine);
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
    if (numberEntred == null) 
        return;
 
    switch (DiceManager.ProcessEntry(numberEntred, shoresWithNumbers))
    {
        case 0:
            Console.WriteLine("You selected to quit the application.. Good bye!");
            Console.WriteLine("Please press any key to close");
            Console.ReadKey();
        return;
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