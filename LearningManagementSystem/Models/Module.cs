namespace LearningManagementSystem.Models
{
    public class Module
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int Order { get; set; }
        public List<Lecture> Lectures { get; set; }
    }
}
