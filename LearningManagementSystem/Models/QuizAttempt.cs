namespace LearningManagementSystem.Models
{
    public class QuizAttempt
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public User Student { get; set; }
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int Score { get; set; }
        public bool Passed { get; set; }
        public List<QuizAnswer> Answers { get; set; }
    }
}
