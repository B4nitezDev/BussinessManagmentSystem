using Core.Entities;
using Core.Interfaces;

namespace Core.VOs
{
    public class Reason: BaseEntity, IAuditApproval
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public required string Value { get; set; }
        public bool IsActive { get; set; }
        
        public List<int> InventoryAdjusmentsId { get; set; } = [];
        
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdate { get; set; }
        public int AddedBy { get; set; }
        public int UpdatedBy { get; set; }
        
        public virtual List<InventoryAdjustments> InventoryAdjusments { get; set; } = [];
    }
}
