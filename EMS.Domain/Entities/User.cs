using EMS.Domain.Abstraction.Entities;

namespace EMS.Domain.Entities
{
    public class User : IEntityBase<Guid>
    {
        public Guid Id { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? AvatarUrl { get; set; }
    }
}
