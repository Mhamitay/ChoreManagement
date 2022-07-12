using homeCleaning;
using homeCleaning.Models;
using NUnit.Framework;
namespace HomeCleanUnit.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Category("Data - Provider")]
        [Test]
        public void DataProvider_Returns_PlayersData_Test()
        {
             List<Player> playerlst;
             List<Shore> shorelst;
       
             DataProvider dp = new DataProvider();
             DataProvider.InitiateData(out playerlst, out shorelst);

             Assert.IsTrue(playerlst.Count > 0);
        }
        [Category("Data Provider")]
        [Test]
        public void DataProvider_Returns_ShoresData_Test()
        {
            List<Player> playerlst;
            List<Shore> shorelst;

            DataProvider.InitiateData(out playerlst, out shorelst);
           
            Assert.IsTrue(shorelst.Count > 0);
        }

        [Category("Rondom Generator")]
        [Test]
        public void AddRondomNumbersToShores_Test()
        {
            List<Player> playerlst;
            List<Shore> shorelst;
            IDictionary<int, Shore> shoresWithNumbers;
            IDictionary<int, Player> playersWithNumbers;

            DataProvider.InitiateData(out playerlst, out shorelst);
            DiceManager.AddRondomNumbersToShoresAndPlayer(playerlst, shorelst, out shoresWithNumbers, out playersWithNumbers);

            Assert.IsTrue(shoresWithNumbers.Count > 0);
        }

        [Category("Rondom Generator")]
        [Test]
        public void AddRondomNumbersToPlayer_Test()
        {
            List<Player> playerlst;
            List<Shore> shorelst;
            IDictionary<int, Shore> shoresWithNumbers;
            IDictionary<int, Player> playersWithNumbers;

            DataProvider.InitiateData(out playerlst, out shorelst);
            DiceManager.AddRondomNumbersToShoresAndPlayer(playerlst, shorelst, out shoresWithNumbers, out playersWithNumbers);

            Assert.IsTrue(playersWithNumbers.Count > 0);
        }
    }
}