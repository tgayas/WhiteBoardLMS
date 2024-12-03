using System.Collections.Generic;

namespace WhiteBoardLMS.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // Navigation properties
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
