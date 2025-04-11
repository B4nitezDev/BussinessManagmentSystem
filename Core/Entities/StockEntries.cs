using Core.Interfaces;

namespace Core.Entities
{
    public class StockEntries: BaseEntity, IAuditApproval
    {
        public int QuantityChange { get; set; }
        public int Cost { get; set; }
        public string? Reference { get; set; }
        public string? Description { get; set; }
        public string Customfield { get; set; } = string.Empty;
        
        public int MovementTypeId { get; set; }
        public int FromLocationId { get; set; }
        public int ProductId { get; set; }
        public int ToLocationId { get; set; }
        public int UserId { get; set; }
        
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdate { get; set; }
        public int AddedBy { get; set; }
        public int UpdatedBy { get; set; }
        
        public virtual Location FromLocation { get; set; }
        public virtual Location ToLocation { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
        public virtual MovementTypes MovementType { get; set; }
    }
}
