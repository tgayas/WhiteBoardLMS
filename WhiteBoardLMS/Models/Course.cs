using System.Collections.Generic;

namespace WhiteBoardLMS.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; } = string.Empty; // Assign a default value to prevent warnings
        public string Description { get; set; } = string.Empty; // Assign a default value to prevent warnings

        // Navigation properties
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>(); // Assign a default value to prevent warnings
    }
}
