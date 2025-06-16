﻿using LearningManagementSystem.Data.@enum;
using System;

namespace LearningManagementSystem.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public User Student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public EnrollmentStatus Status { get; set; }
        public bool CertificateIssued { get; set; }
        public List<Progress> Progress { get; set; }
    }
}
