using QuizApp.Models;
using QuizApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Services
{
    public class QuizAppService
    {
        readonly QuizAppRepository repository;

        public QuizAppService(QuizAppRepository quizAppRepository) => repository = quizAppRepository;

        public void Save(Game game) => repository.Save(game);

        public Game Load() => repository.Load();
    }
}
