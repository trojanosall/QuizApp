namespace QuizApp.Models
{
    public class Question
    {
        public int Id { get; set; } = 0;
        public string Text { get; set; } = "What instrument does Kriszta Csere play?";

        /// <summary>
        /// The right answer is always the first one in the array (index 0).
        /// </summary>
        public string[] Answers { get; set; } =
            {
            "flute",
            "piano",
            "guitar",
            "shamisen"
            };
    }
}
