using Core.Interfaces;
using System.Runtime.CompilerServices;

namespace Core.Entities
{
    public abstract class Purchase: BaseEntity, IAuditApproval
    {
        public DateTime OrderDate { get; set; }
        public string? Description { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }
        public int TotalAmount { get; set; }
        public int Status { get; set; }
        
        public int KioskId { get; set; }
        public int SupplierId { get; set; }
        public List<int> PurchaseDetailsId { get; set; } = [];
        public int? ReceiptId { get; set; }
        
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdate { get; set; }
        public int AddedBy { get; set; }
        public int UpdatedBy { get; set; }
        
        public virtual Kiosk Kiosk { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual List<PurchaseOrderDetails> Details { get; set; } = [];
        public virtual Receipt? Receipt { get; set; }
    }
}
