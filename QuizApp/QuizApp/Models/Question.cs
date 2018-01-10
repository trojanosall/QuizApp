using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Models
{
    public class Question
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public string Text { get; set; }

        /// <summary>
        /// The right answer is always the first one in the array (index 0).
        /// </summary>
        public string[] Answers { get; set; }
    }
}
