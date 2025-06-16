namespace LearningManagementSystem.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int LectureId { get; set; }
        public Lecture Lecture { get; set; }
        public List<Question> Questions { get; set; }
        public int PassingScore { get; set; }
        public int TimeLimit { get; set; }
    }
}
