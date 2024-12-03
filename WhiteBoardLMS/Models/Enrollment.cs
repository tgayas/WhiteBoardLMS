namespace WhiteBoardLMS.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; } // Consider using "Id" as the primary key instead for consistency
        public string UserId { get; set; } = string.Empty; // Update from "Id" to "UserId" for clarity
        public int CourseId { get; set; }

        // Navigation properties
        public User User { get; set; } = new User(); // Assign a default value to prevent warnings, or consider making it nullable
        public Course Course { get; set; } = new Course(); // Assign a default value to prevent warnings, or consider making it nullable
    }
}
