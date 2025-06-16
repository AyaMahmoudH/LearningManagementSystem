using LearningManagementSystem.Data.@enum;

namespace LearningManagementSystem.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public User Student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string TransactionId { get; set; }
        public PaymentStatus Status { get; set; }
    }
}
