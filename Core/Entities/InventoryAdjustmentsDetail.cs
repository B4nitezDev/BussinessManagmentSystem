using Core.Interfaces;

namespace Core.Entities
{
    public class InventoryAdjustmentsDetail: BaseEntity, IAuditApproval
    {
        public int QuantityChange { get; set; }
        public int Cost { get; set; }
        
        public int InventoryAdjustmentsId { get; set; }
        public int ProductId { get; set; }
        public int LocationId { get; set; }
        
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdate { get; set; }
        public int AddedBy { get; set; }
        public int UpdatedBy { get; set; }
        
        public virtual InventoryAdjustments InventoryAdjustments { get; set; }
        public virtual Product Product { get; set; }
        public virtual Location Location { get; set; }
    }
}
