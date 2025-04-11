using Core.Interfaces;

namespace Core.Entities
{
    public class Sales: BaseEntity, IAuditApproval
    {
        public int TotalAmount { get; set; } // Convert to decimal using /100
        public string? OrderKey { get; set; } // Sincronizar con sistemas internos (Indices). EB 10/04/2025
        public string? ExternalOrderKey { get; set; } // Sincronizar con sistemas externos
        public SimpleStatus Status { get; set; } = SimpleStatus.PENDING;
        public string? Reference { get; set; }
        public string Customfield { get; set; } = string.Empty;
        public string Comments { get; set; } = string.Empty;
        public int? TotalOriginalQuantity { get; set; }
        public string? Category { get; set; } // Armar type
        
        public int KioskId { get; set; }
        public int? PaymentMethodId { get; set; }
        public List<int> SalesDetailsId { get; set; } = [];
        
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdate { get; set; }
        public int AddedBy { get; set; }
        public int UpdatedBy { get; set; }
        
        public virtual List<SaleDetail> Details { get; set; } = [];
        public virtual Kiosk Kiosk { get; set; }
        public virtual PaymentMethods PaymentMethod { get; set; }
    }
}
