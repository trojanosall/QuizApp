using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Models
{
    public class Game
    {
        public string PlayerName { get; set; } = "Foxey";
        public int LevelAchieved { get; set; }
        public bool PhoneHelpIsAvailable { get; set; } = true;
        public bool AudienceHelpIsAvailable { get; set; } = true;
        public bool HalferHelpIsAvailable { get; set; } = true;
        public Question ActualQuestion { get; set; }
        public List<Question> AvailableQuestions { get; set; }
        public bool IsWon { get; set; }
    }
}
