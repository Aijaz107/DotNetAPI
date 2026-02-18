namespace WebApplication1.Models
{
    public class UpdateUserDto
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }

        public required string Email { get; set; }
        public required string Password { get; set; }

        public required string PhotoFileName { get; set; }
    }
}
