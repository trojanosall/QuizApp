using Microsoft.AspNetCore.Mvc;
using QuizApp.Models;
using QuizApp.Services;
using System;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuizApp.Controllers
{
    public class HomeController : Controller
    {
        readonly QuizAppService service;

        public HomeController(QuizAppService quizAppService) => service = quizAppService;

        [HttpGet]
        public IActionResult Index()
        {
            var game = new Game();
            game.ActualQuestion = game.QuestionsToBeAsked.Dequeue();
            service.Save(game);
            return View("Question", game);
        }

        [HttpPost("answer")]
        public IActionResult Answer()
        {
            Game game = service.Load();
            game.RightAnswerIsChosen = Convert.ToInt16(Request.Form["chosenAnswer"]) == 1;

            if (game.RightAnswerIsChosen)
            {
                game.LevelAchieved++;
            }
            else
            {
                service.Save(game);
                return View("GameOver", game);
            }

            game.IsOver = game.QuestionsToBeAsked.Count == 0;

            if (game.IsOver)
            {
                game.IsWon = game.RightAnswerIsChosen;
                service.Save(game);
                return View("GameOver", game);
            }

            service.Save(game);
            return View(game);
        }

        [HttpPost("question")]
        public IActionResult Question()
        {
            Game game = service.Load();
            game.ActualQuestion = game.QuestionsToBeAsked.Dequeue();
            service.Save(game);
            return View(game);
        }
    }
}
