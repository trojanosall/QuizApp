using System;
using System.Collections.Generic;

namespace QuizApp.Models
{
    public class Game
    {
        public Game()
        {
            Random random = new Random();

            while (AvailableQuestions.Count>0)
            {
                int index = random.Next(AvailableQuestions.Count);
                QuestionsToBeAsked.Enqueue(AvailableQuestions[index]);
                AvailableQuestions.RemoveAt(index);

                if (QuestionsToBeAsked.Count==15)
                {
                    break;
                }
            }
        }

        public string PlayerName { get; set; } = "Foxey";
        public int LevelAchieved { get; set; }
        public bool RightAnswerIsChosen { get; set; } = false;
        public bool PhoneHelpIsAvailable { get; set; } = true;
        public bool AudienceHelpIsAvailable { get; set; } = true;
        public bool HalferHelpIsAvailable { get; set; } = true;
        public Question ActualQuestion { get; set; }
        public Queue<Question> QuestionsToBeAsked { get; set; } = new Queue<Question>();
        public List<Question> AvailableQuestions { get; set; } = new List<Question>()
        {
            new Question()
            {
                Text = "What instrument does Kriszta Csere play?",
                Answer1 = "flute",
                Answer2 = "piano",
                Answer3 = "guitar",
                Answer4 = "shamisen"
            },
            new Question()
            {
                Text = "What is Papp Kriszti's hobby?",
                Answer1 = "books",
                Answer2 = "running marathons",
                Answer3 = "knitting",
                Answer4 = "films"
            },
            new Question()
            {
                Text = "What was Magdalena Dzsindzsisz's job for 14 years?",
                Answer1 = "working for Index",
                Answer2 = "postman",
                Answer3 = "cook",
                Answer4 = "officer at agriculture ministry"
            }
        };
        public bool IsWon { get; set; } = false;
        public bool IsOver { get; set; } = false;
    }
}
