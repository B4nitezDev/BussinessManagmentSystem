using Core.Interfaces;

namespace Core.Entities
{
    public class StockLevels: BaseEntity, IAuditApproval
    {
        public int CurrentQuantity { get; set; }
        
        public int ProductId { get; set; }
        public int LocationId { get; set; }
        
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdate { get; set; }
        public int AddedBy { get; set; }
        public int UpdatedBy { get; set; }
        
        public virtual Product Product { get; set; }
        public virtual Location Location { get; set; }
    }
}
