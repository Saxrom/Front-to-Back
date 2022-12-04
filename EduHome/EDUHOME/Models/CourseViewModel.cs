﻿using EDUHOME.DAL.Entities;

namespace EDUHOME.Models
{
    public class CourseViewModel
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Content { get; set; }
        public string About { get; set; }
        public string Apply { get; set; }
        public string Certification { get; set; }
        public string Reply { get; set; }
        public DateTime GeginningTime { get; set; }
        public int Duration { get; set; }
        public int ClassDuration { get; set; }
        public string Level { get; set; }
        public string Language { get; set; }
        public int StudentsCount { get; set; }
        public string Assesments { get; set; }
        public int Fee { get; set; }
        public string ImageUrl { get; set; }
        
    }
}
