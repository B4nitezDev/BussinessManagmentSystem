using Core.Interfaces;

namespace Core.Entities
{
    public class SubCategory: BaseEntity, IAuditApproval
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public required string Value { get; set; }
        public int CategoryId { get; set; }
        public bool IsActive { get; set; }
        
        public virtual Category Category { get; set; }

        public DateTime DateAdded { get; set; }
        public DateTime DateUpdate { get; set; }
        public int AddedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}
