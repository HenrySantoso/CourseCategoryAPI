using ActCourse.Backend.Models;

namespace ActCourse.Backend.DTO
{
    public class CourseDTO
    {
        public int CourseId { get; set; }
        public string Name { get; set; } = null!;
        public string? ImageName { get; set; }
        public double Duration { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}
