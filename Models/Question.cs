using System.ComponentModel.DataAnnotations;

namespace QuizApp.Models
{
    public class Question
    {
        [Key]
        public string questionId { get; set; }
        [Required]
        public string quizId { get; set; }
        [Required]
        public string questionText { get; set; }
        [Required]
        public string answer  { get; set; }
        
        public string questionType { get; set; }

    }
}
