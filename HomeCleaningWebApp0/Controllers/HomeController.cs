using HomeCleaningLib;
using HomeCleaningWebApp0.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HomeCleaningWebApp0.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            GameManager gameManager = new GameManager();
            GameDTO gameDTO = new GameDTO();

            gameDTO.shoresWithNumbers = gameManager.GetRandomNumberForEachshore();
            gameDTO.playersWithNumbers = gameManager.GetRandomNumberForEachPlayer();

            return View(gameDTO);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}