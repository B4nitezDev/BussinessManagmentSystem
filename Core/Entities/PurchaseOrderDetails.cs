using Core.Interfaces;

namespace Core.Entities
{
    public class PurchaseOrderDetails: BaseEntity, IAuditApproval
    {
        public int QuantityOrdered { get; set; }
        public int Cost { get; set; }
        
        public int PurchaseOrderId { get; set; }
        public int ProductId { get; set; }
        
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdate { get; set; }
        public int AddedBy { get; set; }
        public int UpdatedBy { get; set; }
        
        public virtual Purchase Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
