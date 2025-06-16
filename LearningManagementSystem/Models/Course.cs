﻿using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.Reflection;

namespace LearningManagementSystem.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ThumbnailUrl { get; set; }
        public decimal Price { get; set; }
        public int InstructorId { get; set; }
        public User Instructor { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsPublished { get; set; }
        public string Level { get; set; } // مبتدئ، متوسط، متقدم
        public int DurationInMinutes { get; set; }
        public List<Module> Modules { get; set; }
        public List<Enrollment> Enrollments { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
