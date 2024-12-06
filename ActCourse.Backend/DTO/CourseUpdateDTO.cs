namespace ActCourse.Backend.DTO
{
    public class CourseUpdateDTO
    {
        public string Name { get; set; } = null!;
        public string? ImageName { get; set; }
        public double Duration { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
    }
}
