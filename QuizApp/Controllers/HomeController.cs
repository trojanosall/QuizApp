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

        [HttpPost("question")]
        public IActionResult Question()
        {
            Game game = service.Load();
            game.ActualQuestion = game.QuestionsToBeAsked.Dequeue();
            service.Save(game);
            return View(game);
        }

        [HttpPost("answer")]
        public IActionResult Answer()
        {
            Game game = service.Load();
            game.RightAnswerIsChosen = Convert.ToInt16(Request.Form["chosenAnswer"]) == 1;

            if (game.RightAnswerIsChosen)
            {
                game.LevelAchieved++;
                game.AudienceHelpResult = 0;
                game.PhoneHelpResult = 0;
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

        [HttpPost("help")]
        public IActionResult HelpAsked()
        {
            Game game = service.Load();
            Random random = new Random();
            int maxRandomValue;

            switch (Request.Form["chosenHelper"])
            {
                case "Phone":
                    game.PhoneHelpIsAvailable = false;
                    maxRandomValue = String.IsNullOrEmpty(game.ActualQuestion.Answer4) ? 2 : 4;
                    game.PhoneHelpResult = random.Next(1, maxRandomValue);
                    break;
                case "Audience":
                    game.AudienceHelpIsAvailable = false;
                    maxRandomValue = String.IsNullOrEmpty(game.ActualQuestion.Answer4) ? 2 : 4;
                    game.AudienceHelpResult = random.Next(1, maxRandomValue);
                    break;
                case "Halfer":
                    game.HalferHelpIsAvailable = false;
                    game.ActualQuestion.Answer3 = String.Empty;
                    game.ActualQuestion.Answer4 = String.Empty;
                    break;
                default:
                    break;
            }

            service.Save(game);
            return View("Question", game);
        }
    }
}
