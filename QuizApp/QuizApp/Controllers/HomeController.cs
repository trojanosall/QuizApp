using Microsoft.AspNetCore.Mvc;
using QuizApp.Models;
using QuizApp.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuizApp.Controllers
{
    public class HomeController : Controller
    {
        Game game;
        QuizAppService QuizAppService;

        public HomeController(QuizAppService quizAppService)
        {
            QuizAppService = quizAppService;
        }

        [HttpGet]
        public IActionResult Index([FromBody] Game game)
        {
            if (game == null)
            {
                game = new Game();
            }
            return View(game);
        }
    }
}
