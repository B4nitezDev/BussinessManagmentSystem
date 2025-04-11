using Core.Interfaces;

namespace Core.Entities
{
    public class Receipt:  BaseEntity, IAuditApproval
    {
        public DateTime ReceiptDate { get; set; }
        public int InvoiceNumber { get; set; }
        
        public int PurchaseId { get; set; }
        public int SupplierId { get; set; }
        public List<int> ReceiptDetailsId { get; set; } = [];
        
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdate { get; set; }
        public int AddedBy { get; set; }
        public int UpdatedBy { get; set; }
        
        public virtual Purchase Purchase { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual List<ReceiptDetails> Details { get; set; } = [];
    }
}
