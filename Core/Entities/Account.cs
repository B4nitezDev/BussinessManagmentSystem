using Core.Interfaces;

namespace Core.Entities
{
    public class Account: BaseEntity, IAuditApproval
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string? Description { get; set; }
        
        public List<int> AccountConfigs { get; set; }
        public List<int> ProductsId { get; set; }
        public List<int> ListOptionsId { get; set; }
        public List<int> KioskId { get; set; }
        public List<int> SuppliersId { get; set;}
        
        public DateTime DateAdded { get; set; } 
        public DateTime DateUpdate { get; set; }
        public int AddedBy { get; set; }
        public int UpdatedBy { get; set; }
        
        public virtual List<Product> Products { get; set; }
        public virtual List<AccountConfig> Configs { get; set; }
        public virtual List<ListOption> ListOptions { get; set; }
        public virtual List<Kiosk> Kiosks { get; set; }
        public virtual List<Supplier> Suppliers { get; set; }
    }
}
