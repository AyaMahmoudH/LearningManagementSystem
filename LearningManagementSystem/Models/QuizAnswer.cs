namespace LearningManagementSystem.Models
{
    public class QuizAnswer
    {
        public int Id { get; set; }
        public int QuizAttemptId { get; set; }
        public QuizAttempt QuizAttempt { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public int SelectedAnswerId { get; set; }
        public Answer SelectedAnswer { get; set; }
    }
}
