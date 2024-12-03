using System.Collections.Generic;

namespace WhiteBoardLMS.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }

        // Navigation properties
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
