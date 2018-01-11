using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Models
{
    public class Game
    {

        public Game()
        {
            AvailableQuestions.Enqueue(new Question()
            {
                Text = "What instrument does Kriszta Csere play?",
                Answer1 = "flute",
                Answer2 = "piano",
                Answer3 = "guitar",
                Answer4 = "shamisen"
            });
            AvailableQuestions.Enqueue(new Question()
            {
                Text = "What is Papp Kriszti's hobby?",
                Answer1 = "books",
                Answer2 = "running marathons",
                Answer3 = "knitting",
                Answer4 = "films"
            });
            AvailableQuestions.Enqueue(new Question()
            {
                Text = "What was Magdalena Dzsindzsisz's job for 14 years?",
                Answer1 = "working for Index",
                Answer2 = "postman",
                Answer3 = "cook",
                Answer4 = "officer at agriculture ministry"
            });

            ActualQuestion = AvailableQuestions.Dequeue();
        }

        public string PlayerName { get; set; } = "Foxey";
        public int LevelAchieved { get; set; }
        public bool PhoneHelpIsAvailable { get; set; } = true;
        public bool AudienceHelpIsAvailable { get; set; } = true;
        public bool HalferHelpIsAvailable { get; set; } = true;
        public Question ActualQuestion { get; set; }
        public Queue<Question> AvailableQuestions { get; set; } = new Queue<Question>();
        public bool IsWon { get; set; } = false;
    }
}
