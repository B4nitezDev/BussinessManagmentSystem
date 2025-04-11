using Core.Interfaces;

namespace Core.Entities
{
    public class SaleDetail: BaseEntity, IAuditApproval
    {
        public int ExternalLine { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public int LineTotal { get; set; }
        public int? Discount { get; set; }
        public int? Tax { get; set; }
        public int Status { get; set; } // TODO: Agregar enum. EB 10/04/2025
        
        public int SalesId { get; set; }
        public int ProductId { get; set; }
        
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdate { get; set; }
        public int AddedBy { get; set; }
        public int UpdatedBy { get; set; }
        
        public virtual Product Product { get; set; }
        public virtual Sales Sales { get; set; }
    }
}
