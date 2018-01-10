using Microsoft.AspNetCore.Mvc;
using QuizApp.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuizApp.Controllers
{
    public class HomeController : Controller
    {
        QuizAppService QuizAppService;

        public HomeController(QuizAppService quizAppService)
        {
            QuizAppService = quizAppService;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
