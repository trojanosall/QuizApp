using QuizApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Services
{
    public class QuizAppService
    {
        QuizAppRepository QuizAppRepository;

        public QuizAppService(QuizAppRepository quizAppRepository)
        {
            QuizAppRepository = quizAppRepository;
        }
    }
}
