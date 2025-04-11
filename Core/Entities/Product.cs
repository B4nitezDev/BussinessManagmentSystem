using Core.Interfaces;
using Core.VOs;

namespace Core.Entities
{
    public class Product: BaseEntity, IAuditApproval
    {
        public required ProductName Name { get; set; }
        public string? Description { get; set; }
        public required string SkuCode { get; set; }
        public string Customfield { get; set; } = string.Empty;
        public int CostPrice { get; set; } // Convert to decimal using /1000
        public int SalePrice { get; set; } // Convert to decimal using /1000
        public int MinStockLevel { get; set; }
        public int TargetStockLevel { get; set; }
        public bool IsActive { get; set; }
        
        public int AccountId { get; set; }
        public int BrandsId { get; set; }
        public int UnitOfMeasureId { get; set; }
        public List<int> CategoryId { get; set; } = [];
        public List<int> SalesDetailsId { get; set; } = [];
        public List<int> InventoryAdjusmentsDetailId { get; set; } = [];
        public List<int> StockLevelsId { get; set; } = [];
        public int ProductSupplierId { get; set; }
        public List<int> PurchaseDetailsId { get; set; } = [];
        public List<int> ReceiptDetailsId { get; set; } = [];
        
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdate { get; set; }
        public int AddedBy { get; set; }
        public int UpdatedBy { get; set; }
        
        public virtual UnitOfMeasure UnitOfMeasure { get; set; }
        
        public virtual Account Account { get; set; }
        public virtual Brand Brands { get; set; }
        public virtual List<Category> Categories { get; set; } = [];
        public virtual List<SaleDetail> Details { get; set; } = [];
        public virtual List<InventoryAdjustmentsDetail> InventoryAdjustmentsDetails { get; set; } = [];
        public virtual List<StockLevels> StockLevels { get; set; } = [];
        public virtual ProductSupplier ProductSupplier { get; set; }
        public virtual List<PurchaseOrderDetails> PurchaseDetails { get; set; } = [];
        public virtual List<ReceiptDetails> ReceiptDetails { get; set; } = [];
    }
}
