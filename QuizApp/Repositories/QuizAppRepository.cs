using Newtonsoft.Json;
using QuizApp.Models;
using System;
using System.IO;

namespace QuizApp.Repositories
{
    public class QuizAppRepository
    {
        public void Save(Game game) => File.WriteAllText(@"Game.txt", JsonConvert.SerializeObject(game));

        public Game Load() => JsonConvert.DeserializeObject<Game>(File.ReadAllText(@"Game.txt"));
    }
}
