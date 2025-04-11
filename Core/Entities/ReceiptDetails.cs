using Core.Interfaces;

namespace Core.Entities
{
    public class ReceiptDetails: BaseEntity, IAuditApproval
    {
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public int LineTotal { get; set; }
        public int? Discount { get; set; }
        public int? Tax { get; set; }
        
        public int ReceiptId { get; set; }
        public int ProductId { get; set; }
        public int LocationId { get; set; }
        
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdate { get; set; }
        public int AddedBy { get; set; }
        public int UpdatedBy { get; set; }
        
        public virtual Receipt Receipt { get; set; }
        public virtual Product Product { get; set; }
        public virtual Location Location { get; set; }
    }
}
