
using ChoreManagement.core.lib.Models;
using ChoreManagement.core.lib.Services;

ChoreEntity choreEntity = new();

ChoreManager.GetInitialData(out choreEntity.playerlst, out choreEntity.chorelst);
ChoreManager.AddRondomNumbersToChoresAndPlayer(choreEntity.playerlst, choreEntity.chorelst, out choreEntity.choresWithNumbers, out choreEntity.playersWithNumbers);

DisplayPlayers(choreEntity.playersWithNumbers);
DisplaySelectNumber(choreEntity.choresWithNumbers);

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
 static void DisplaySelectNumber(IDictionary<int, Chore> choresWithNumbers)
{
    Console.Write(Environment.NewLine + "Please select on of the following numbers");
    Console.WriteLine();

    foreach (int number in choresWithNumbers.Keys)
    {
        Console.WriteLine("- " + number);
    }
    var numberEntred = Console.ReadLine();
    if (numberEntred == null) 
        return;
 
    switch (ChoreManager.ProcessEntry(numberEntred, choresWithNumbers))
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
            DisplaySelectNumber(choresWithNumbers);
            break;
        default:
            DisplaySelectNumber(choresWithNumbers);
            break;
    }
}