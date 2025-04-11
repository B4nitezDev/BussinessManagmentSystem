using Core.Interfaces;

namespace Core.Entities
{
    public class ListOption: BaseEntity, IAuditApproval
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string Value { get; set; }
        public bool IsActive { get; set; }
        
        public int AccountId { get; set; }
        
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdate { get; set; }
        public int AddedBy { get; set; }
        public int UpdatedBy { get; set; }
        
        public virtual Account Account { get; set; }
    }
}
