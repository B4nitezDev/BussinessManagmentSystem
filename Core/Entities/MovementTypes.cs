using Core.Interfaces;

namespace Core.Entities
{
    public class MovementTypes: BaseEntity, IAuditApproval
    {
        public string TypeCode { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public string Multiplier { get; set; }
        
        public List<int> StockEntriesId { get; set; } = [];
        
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdate { get; set; }
        public int AddedBy { get; set; }
        public int UpdatedBy { get; set; }
        
        public virtual List<StockEntries> StockEntries { get; set; } = [];
    }
}
