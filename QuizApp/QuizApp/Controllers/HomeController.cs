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

        public HomeController(QuizAppService quizAppService)
        {
            service = quizAppService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            game = new Game();
            return View(game);
        }

        [HttpPost("answer")]
        public IActionResult Answer(Game game)
        {
            string seqStringOfChoosenAnswer;
            if (Request.Form.ContainsKey("chosenAnswer"))
            {
                seqStringOfChoosenAnswer = Request.Form["chosenAnswer"];
                int seqIntOfChoosenAnswer = int.Parse(seqStringOfChoosenAnswer);
            }



            //    TryGetValue("chosenAnswer", out numiu)
            //if (Request.Form.Keys.Contains("chosenAnswer"))
            //{
            //    string a = Request.Form.Keys["chosenAnswer"];

            //}
            //string k = Request.Form[key];
            return View(game);
        }

        [HttpPost("question")]
        public IActionResult Question(Game game)
        {
            return View("Index", game);
        }
    }
}
