using Core.Interfaces;

namespace Core.Entities
{
    public class Location: BaseEntity, IAuditApproval
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
        public bool IsDefault { get; set; }
        public bool IsSaleable { get; set; }
        public bool IsReceiptZone { get; set; }
        
        public List<int> StockLevelsId { get; set; } = [];
        public List<int> InventoryAdjusmentsDetailsId { get; set; } = [];
        public List<int> ToStockEntryId { get; set; } = [];
        public List<int> FromStockEntryId { get; set; } = [];
        public int KioskId { get; set; }
        public List<int> ReceiptDetailsId { get; set; } = [];
        
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdate { get; set; }
        public int AddedBy { get; set; }
        public int UpdatedBy { get; set; }
        
        public virtual List<StockLevels> StockLevels { get; set; } = []; // product -> stock level -> location
        public virtual List<InventoryAdjustmentsDetail> InventoryAdjustmentsDetails { get; set; } = [];
        public virtual List<StockEntries> ToStockEntry { get; set; } = [];
        public virtual List<StockEntries> FromStockEntry { get; set; } = [];
        public virtual Kiosk Kiosk { get; set; }
        public virtual List<ReceiptDetails> ReceiptDetails { get; set; } = [];
    }
}
