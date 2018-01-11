using Microsoft.AspNetCore.Mvc;
using QuizApp.Models;
using QuizApp.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuizApp.Controllers
{
    public class HomeController : Controller
    {
        Game game;
        QuizAppService service;

        public HomeController(QuizAppService quizAppService) => service = quizAppService;

        [HttpGet]
        public IActionResult Index()
        {           
            game = new Game();
            return View("Question", game);
        }

        [HttpPost("answer")]
        public IActionResult Answer(Game game) => View(game);

        [HttpPost("question")]
        public IActionResult Question(Game game)
        {          
            return View(game);
        }
    }
}
