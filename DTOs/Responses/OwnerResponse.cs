namespace IceCity2.DTOs.Responses
{
    public class OwnerResponse
    {
        public Guid Id { get; set; }

        public string UserId { get; set; } = null!;

        public string Username { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Phone { get; set; } = null!;
    }
}