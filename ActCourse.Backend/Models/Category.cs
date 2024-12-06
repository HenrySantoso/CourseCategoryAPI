namespace ActCourse.Backend.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
