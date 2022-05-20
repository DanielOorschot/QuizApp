using System.ComponentModel.DataAnnotations;

namespace QuizApp.Models
{
    public class Quiz
    {
        [Key]
        public int quizId { get; set; }
        [Required]
        public string quizName { get; set; }
        public int numberOfQuestions { get; set; }
        public string authorName { get; set; }


    }
}
