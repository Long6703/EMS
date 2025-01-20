using EMS.Domain.Abstraction.Entities;

namespace EMS.Domain.Entities
{
    public class Major : IEntityBase<int>, IUpdateActive
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
    }
}
