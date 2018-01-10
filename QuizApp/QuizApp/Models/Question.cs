namespace QuizApp.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string TheQuestion { get; set; }

        /// <summary>
        /// The right answer is always the first one in the array (index 0).
        /// </summary>
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
    }
}
