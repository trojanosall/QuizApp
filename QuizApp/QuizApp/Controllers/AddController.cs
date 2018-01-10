using Microsoft.AspNetCore.Mvc;
using QuizApp.Entities;
using QuizApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Controllers
{
    [Route("/quiz")]
    public class AddController : Controller
    {
        QuestionContext QuestionContext;

        public AddController(QuestionContext questionContext)
        {
            QuestionContext = questionContext;
        }
        [HttpGet]
        [Route("add")]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(string answer1, string answer2, string answer3, string answer4, string question)
        {
            QuestionContext.Questions.Add(new Question() { Answer1 = answer1, Answer2 = answer2, Answer3 = answer3, Answer4 = answer4, Text = question});
            QuestionContext.SaveChanges();
            return RedirectToAction("New");
        }
    }
}
