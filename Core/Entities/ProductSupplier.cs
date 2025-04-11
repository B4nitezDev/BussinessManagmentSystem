using Core.Interfaces;

namespace Core.Entities
{
    public class ProductSupplier: BaseEntity, IAuditApproval
    {
        public string Code { get; set; }
        public int LastCostPrice { get; set; }
        
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdate { get; set; }
        public int AddedBy { get; set; }
        public int UpdatedBy { get; set; }
        
        public virtual Product Product { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
