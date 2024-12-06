namespace ActCourse.Backend.DTO
{
    public class UserWithTokenDTO
    {
        public string Email { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Token { get; set; } = null!;
    }
}
